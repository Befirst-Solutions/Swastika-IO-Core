﻿// Licensed to the Swastika I/O Foundation under one or more agreements.
// The Swastika I/O Foundation licenses this file to you under the GNU General Public License v3.0 license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace Swastika.Cms.Lib.Models.Account
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserClaimsApplicationUser = new HashSet<AspNetUserClaims>();
            AspNetUserClaimsUser = new HashSet<AspNetUserClaims>();
            AspNetUserLoginsApplicationUser = new HashSet<AspNetUserLogins>();
            AspNetUserLoginsUser = new HashSet<AspNetUserLogins>();
            AspNetUserRolesApplicationUser = new HashSet<AspNetUserRoles>();
            AspNetUserRolesUser = new HashSet<AspNetUserRoles>();
            AspNetUserTokens = new HashSet<AspNetUserTokens>();
        }

        public string Id { get; set; }
        public int AccessFailedCount { get; set; }
        public string Avatar { get; set; }
        public string ConcurrencyStamp { get; set; }
        public int CountryId { get; set; }
        public string Culture { get; set; }
        public DateTime? Dob { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public bool IsActived { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime LastModified { get; set; }
        public string LastName { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public string ModifiedBy { get; set; }
        public string NickName { get; set; }
        public string NormalizedEmail { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string RegisterType { get; set; }
        public string SecurityStamp { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string UserName { get; set; }

        public ICollection<AspNetUserClaims> AspNetUserClaimsApplicationUser { get; set; }
        public ICollection<AspNetUserClaims> AspNetUserClaimsUser { get; set; }
        public ICollection<AspNetUserLogins> AspNetUserLoginsApplicationUser { get; set; }
        public ICollection<AspNetUserLogins> AspNetUserLoginsUser { get; set; }
        public ICollection<AspNetUserRoles> AspNetUserRolesApplicationUser { get; set; }
        public ICollection<AspNetUserRoles> AspNetUserRolesUser { get; set; }
        public ICollection<AspNetUserTokens> AspNetUserTokens { get; set; }
    }
}