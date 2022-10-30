using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DgKala.Convertors;
using DgKala.Generators;
using DgKala.Models.Context;
using DgKala.Models.Entities.User;
using DgKala.Models.Entities.Wallet;
using DgKala.Models.ViewModels.AccountViewModel;
using DgKala.Models.ViewModels.AdminViewModel;
using DgKala.Models.ViewModels.InformationViewModel;
using DgKala.Models.ViewModels.WalletViewModel;
using Microsoft.EntityFrameworkCore;
using TopLearn.Core.Security;


namespace DgKala.Repository
{
    public interface IUserServices
    {
        #region User

        bool IsExistsUserName(string userName);
        bool IsExistsEmail(string email);
        int AddUser(User user);
        User LoginUser(LoginViewModel login);
        User GetUserByEmail(string email);
        User GetUserByUserId(int userId);
        User GetUserByActiveCode(string activeCode);
        User GetUserByUserName(string username);
        void UpdateUser(User user);
        bool ActiveAccount(string activeCode);
        int GetUserIdByUsername(string username);
        void DeleteUser(int userId);

        #endregion

        #region UserPanel

        InformationViewModel GetUserInformation(string username);
        InformationViewModel GetUserInformation(int userId);

        SitBarViewModel GetSiteBarUserPanelDate(string username);
        EditProfileViewModel GetDateForEditProfileUser(string username);
        void EditProfile(string username, EditProfileViewModel profile);
        bool CompareOldPassword(string username, string oldPassword);
        void ChangeUserPassword(string username, string newPassword);

        #endregion

        #region Wallet

        int BalanceUserWallet(string username);
        List<WalletViewModel> GetWalletUser(string username);
        int ChargeWallet(string username, string description, int amount, bool isPay = false);
        int AddWallet(Wallet wallet);
        Wallet GetWalletByWalletId(int walletId);
        void UpdateWallet(Wallet wallet);

        #endregion


        #region Admin Panel

        UserForAdminViewModel GetUser(int pageId = 1, string filterEmail = "", string filterUserName = "");
        UserForAdminViewModel GetDeleteUser(int pageId = 1, string filterEmail = "", string filterUserName = "");

        int AddUserFromAdmin(CreateUserViewModel user);
        EditUserViewModel GetUserForShowEditModel(int userid);
        void EditUserForAdmin(EditUserViewModel editUser);

        #endregion



    }




    public class UserServices : IUserServices
    {
        private DgkalaContext _context;

        public UserServices(DgkalaContext context)
        {
            _context = context;
        }
        public bool IsExistsUserName(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }
        public bool IsExistsEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }
        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.UserId;
        }
        public User LoginUser(LoginViewModel login)
        {
            string passwordHelper = PasswordHelper.EncodePasswordMd5(login.Password);
            string email = FixText.FixEmail(login.Email);
            return _context.Users.SingleOrDefault(u => u.Email == email && u.Password == passwordHelper);
        }
        public User GetUserByEmail(string email)
        {
            return _context.Users.SingleOrDefault(u => u.Email == email);
        }
        public User GetUserByUserId(int userId)
        {
            return _context.Users.Find(userId);
        }
        public User GetUserByActiveCode(string activeCode)
        {
            return _context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
        }
        public User GetUserByUserName(string username)
        {
            return _context.Users.SingleOrDefault(u => u.UserName == username);
        }
        public void UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }
        public bool ActiveAccount(string activeCode)
        {
            var user = _context.Users.SingleOrDefault(a => a.ActiveCode == activeCode);
            if (user == null || user.IsActive)
            {
                return false;
            }

            user.IsActive = true;
            user.ActiveCode = NameGenerator.GeneratorUniqCode();
            _context.SaveChanges();
            return true;

        }
        public int GetUserIdByUsername(string username)
        {
            return _context.Users.Single(u => u.UserName == username).UserId;
        }
        public void DeleteUser(int userId)
        {
            User user = GetUserByUserId(userId);
            user.IsDelete = true;
            UpdateUser(user);
        }
        public InformationViewModel GetUserInformation(string username)
        {
            var user = GetUserByUserName(username);
            InformationViewModel information = new InformationViewModel();
            information.UserName = user.UserName;
            information.Email = user.Email;
            information.RegisterDate = user.RegisterDate;
            information.Wallet = BalanceUserWallet( user.UserName);
            return information;
        }
        public InformationViewModel GetUserInformation(int userId)
        {
            var user = GetUserByUserId(userId);
            InformationViewModel information = new InformationViewModel();
            information.UserName = user.UserName;
            information.Email = user.Email;
            information.RegisterDate = user.RegisterDate;
            information.Wallet = BalanceUserWallet(user.UserName);
            return information;
        }
   
    public SitBarViewModel GetSiteBarUserPanelDate(string username)
    {
        return _context.Users.Where(u => u.UserName == username).Select(u => new SitBarViewModel()
        {
            UserName = u.UserName,
            ImageName = u.UserAvatar,
            RegisterDate = u.RegisterDate

        }).Single();
    }
    public EditProfileViewModel GetDateForEditProfileUser(string username)
    {
        return _context.Users.Where(u => u.UserName == username).Select(u => new EditProfileViewModel()
        {
            UserName = u.UserName,
            AvatarName = u.UserAvatar,
            Email = u.Email

        }).Single();
    }
    public void EditProfile(string username, EditProfileViewModel profile)
    {
        if (profile.UserAvatar != null)
        {
            string imagePath = "";
            if (profile.AvatarName != "1.jpg")
            {
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", profile.AvatarName);
                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                }
            }

            profile.AvatarName = NameGenerator.GeneratorUniqCode() + Path.GetExtension(profile.UserAvatar.FileName);
            imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", profile.AvatarName);

            using (var stream = new FileStream(imagePath, FileMode.Create))
            {
                profile.UserAvatar.CopyTo(stream);
            }
        }

        var user = GetUserByUserName(username);
        user.UserName = profile.UserName;
        user.Email = profile.Email;
        user.UserAvatar = profile.AvatarName;

        UpdateUser(user);
    }
    public bool CompareOldPassword(string username, string oldPassword)
    {
        string hashOldPassword = PasswordHelper.EncodePasswordMd5(oldPassword);
        return _context.Users.Any(u => u.UserName == username && u.Password == hashOldPassword);

    }
    public void ChangeUserPassword(string username, string newPassword)
    {
        var user = GetUserByUserName(username);
        user.Password = PasswordHelper.EncodePasswordMd5(newPassword);
        UpdateUser(user);
    }
    public int BalanceUserWallet(string username)
    {
        int userId = GetUserIdByUsername(username);
        var enter = _context.Wallets.Where(u => u.UserId == userId && u.TypeId == 1 && u.IsPay)
            .Select(u => u.Amount)
            .ToList();
        var exit = _context.Wallets.Where(u => u.UserId == userId && u.TypeId == 2).Select(u => u.Amount).ToList();
        return (enter.Sum() - exit.Sum());
    }
    public List<WalletViewModel> GetWalletUser(string username)
    {
        int userId = GetUserIdByUsername(username);
        return _context.Wallets.Where(w => w.IsPay && w.UserId == userId)
            .Select(w => new WalletViewModel()
            {
                Amount = w.Amount,
                Datetime = w.CreateDate,
                Description = w.Description,
                Type = w.TypeId
            }).ToList();
    }
    public int ChargeWallet(string username, string description, int amount, bool isPay = false)
    {
        Wallet wallet = new Wallet()
        {
            Amount = amount,
            CreateDate = DateTime.Now,
            Description = description,
            IsPay = false,
            TypeId = 1,
            UserId = GetUserIdByUsername(username),

        };
        return AddWallet(wallet);
    }
    public int AddWallet(Wallet wallet)
    {
        _context.Wallets.Add(wallet);
        _context.SaveChanges();
        return wallet.WalletId;

    }
    public Wallet GetWalletByWalletId(int walletId)
    {
        return _context.Wallets.Find(walletId);
    }
    public void UpdateWallet(Wallet wallet)
    {
        _context.Wallets.Update(wallet);
        _context.SaveChanges();
    }
    public UserForAdminViewModel GetUser(int pageId = 1, string filterEmail = "", string filterUserName = "")
    {
        IQueryable<User> result = _context.Users;
        if (!string.IsNullOrEmpty(filterEmail))
        {
            result = result.Where(u => u.Email.Contains(filterEmail));
        }

        if (!string.IsNullOrEmpty(filterUserName))
        {
            result = result.Where(u => u.UserName.Contains(filterUserName));
        }

        //show Item In Page
        int take = 20;
        int skip = (pageId - 1) * take;


        UserForAdminViewModel list = new UserForAdminViewModel();
        list.CurrentPage = pageId;
        list.PageCount = result.Count() / take;
        list.Users = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList();
        return list;
    }
    public UserForAdminViewModel GetDeleteUser(int pageId = 1, string filterEmail = "", string filterUserName = "")
    {
        IQueryable<User> result = _context.Users.IgnoreQueryFilters().Where(u => u.IsDelete);
        if (!string.IsNullOrEmpty(filterUserName))
        {
            result = result.Where(u => u.UserName.Contains(filterUserName));
        }

        if (!string.IsNullOrEmpty(filterEmail))
        {
            result = result.Where(u => u.Email.Contains(filterEmail));
        }
        //Show Item In Page
        int take = 20;
        int skip = (pageId - 1) * take;

        UserForAdminViewModel list = new UserForAdminViewModel();
        list.PageCount = pageId;
        list.CurrentPage = result.Count() / take;
        list.Users = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList();
        return list;

    }
    public int AddUserFromAdmin(CreateUserViewModel user)
    {
        User addUser = new User();
        addUser.Password = PasswordHelper.EncodePasswordMd5(user.Password);
        addUser.ActiveCode = NameGenerator.GeneratorUniqCode();
        addUser.Email = user.Email;
        addUser.IsActive = true;
        addUser.RegisterDate = DateTime.Now;
        addUser.UserName = user.UserName;

        #region Save Avatar

        if (user.UserAvatar != null)
        {
            string imagePath = "";


            addUser.UserAvatar = NameGenerator.GeneratorUniqCode() + Path.GetExtension(user.UserAvatar.FileName);
            imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", addUser.UserAvatar);

            using (var stream = new FileStream(imagePath, FileMode.Create))
            {
                user.UserAvatar.CopyTo(stream);
            }
        }

        #endregion


        return AddUser(addUser);


    }
    public EditUserViewModel GetUserForShowEditModel(int userid)
    {
        return _context.Users.Where(u => u.UserId == userid)
            .Select(u => new EditUserViewModel()
            {
                UserId = u.UserId,
                Email = u.Email,
                AvatarName = u.UserAvatar,
                UserName = u.UserName,
                UserRoles = u.UserRoles.Select(r => r.RoleId).ToList()

            }).Single();
    }
    public void EditUserForAdmin(EditUserViewModel editUser)
    {
        User user = GetUserByUserId(editUser.UserId);
        user.Email = editUser.Email;
        if (!string.IsNullOrEmpty(editUser.Password))
        {
            user.Password = PasswordHelper.EncodePasswordMd5(editUser.Password);

        }

        if (editUser.UserAvatar != null)
        {
            if (editUser.AvatarName != "1.jpg")
            {
                //Delete Old Image
                string imageDelete = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar",
                    editUser.AvatarName);
                if (File.Exists(imageDelete))
                {
                    File.Delete(imageDelete);
                }
            }

            //Save New Image 

            user.UserAvatar = NameGenerator.GeneratorUniqCode() + Path.GetExtension(editUser.UserAvatar.FileName);
            string imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", user.UserAvatar);
            using (var stream = new FileStream(imagepath, FileMode.Create))
            {
                editUser.UserAvatar.CopyTo(stream);
            }

            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
}

