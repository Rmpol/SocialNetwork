﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.BLL.Models
{
    public class UserAddFriendData
    {
        public int UserId { get; set; }
        public string FriendEmail { get; set; }
    }
}