﻿using System;

namespace TelegramTestBot.Contract
{
    public class CheckPartnerResponseModel
    {
        public Guid PartnerId { get; set; }
        public string PartnerName { get; set; }
    }
}
