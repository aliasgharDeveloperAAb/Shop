using System.Collections.Generic;
using System.Linq;
using DgKala.Models.Context;
using DgKala.Models.Entities.Permissions;
using DgKala.Models.Entities.User;

namespace DgKala.Repository
{
    public interface IPermissionServices
    {
        #region Role

        List<Role> GerRoles();
        int AddRole(Role role);
        Role GetRoleById(int roleId);
        void UpdateRole(Role role);
        void DeleteRole(Role role);
        void AddRolesToUser(List<int> roleIds, int userId);
        void EditRolesUser(int userId, List<int> rolesId);

        #endregion

        #region Permission

        List<Permission> GetAllPermission();
        void AddPermissionToRole(int roleId, List<int> permissions);
        List<int> PermissionsRole(int roleId);
        void UpdatePermissionRole(int roleId, List<int> permissions);
        bool CheckerPermission(int permissionId, string userName);

        #endregion
    }



    public class PermissionServices : IPermissionServices
    {
        private DgkalaContext _context;

        public PermissionServices(DgkalaContext context)
        {
            _context = context;
        }
        public List<Role> GerRoles()
        {
            return _context.Roles.ToList();
        }
        public int AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role.RoleId;
        }
        public Role GetRoleById(int roleId)
        {
            return _context.Roles.Find(roleId);
        }
        public void UpdateRole(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
        }
        public void DeleteRole(Role role)
        {
            role.IsDelete = true;
            UpdateRole(role);

        }
        public void AddRolesToUser(List<int> roleIds, int userId)
        {
            foreach (int roleId in roleIds)
            {
                _context.UserRoles.Add(new UserRole()
                {
                    RoleId = roleId,
                    UserId = userId,
                });


            }
            _context.SaveChanges();
        }
        public void EditRolesUser(int userId, List<int> rolesId)
        {
            //  Delete All Roles User
            _context.UserRoles.Where(r => r.UserId == userId).ToList()
                .ForEach(r => _context.UserRoles.Remove(r));
            // Add New Role
            AddRolesToUser(rolesId, userId);
        }
        public List<Permission> GetAllPermission()
        {
            return _context.Permission.ToList();
        }
        public void AddPermissionToRole(int roleId, List<int> permissions)
        {
            foreach (var p in permissions)
            {
                _context.RolePermission.Add(new RolePermission()
                {
                    PermissionId = p,
                    RoleId = roleId
                });
            }

            _context.SaveChanges();
        }
        public List<int> PermissionsRole(int roleId)
        {
            return _context.RolePermission
                .Where(p => p.RoleId == roleId)
                .Select(p => p.PermissionId).ToList();
        }
        public void UpdatePermissionRole(int roleId, List<int> permissions)
        {
            _context.RolePermission.Where(p => p.RoleId == roleId)
                .ToList()
                .ForEach(p => _context.RolePermission.Remove(p));

            AddPermissionToRole(roleId, permissions);
        }
        public bool CheckerPermission(int permissionId, string userName)
        {
            int userId = _context.Users.Single(u => u.UserName == userName).UserId;

            List<int> UserRole = _context.UserRoles
                .Where(r => r.UserId == userId).Select(r => r.RoleId).ToList();

            if (!UserRole.Any())

                return false;


            List<int> rolePermission = _context.RolePermission
                .Where(r => r.PermissionId == permissionId)
                .Select(p=>p.RoleId).ToList();

            return rolePermission.Any(p => UserRole.Contains(p));
        }
    }
}
