﻿using System.Threading.Tasks;

namespace Portfolio.Core.Interfaces;

public interface IEmailSender
{
  Task SendEmailAsync(string to, string from, string subject, string body);
}
