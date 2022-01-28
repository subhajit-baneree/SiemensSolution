﻿using Discount.Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Calculator.Service.Interfaces
{
    public interface IInputService
    {
        UserModel GetLoginDetails();
        CalculationInputModel GetCalculationDetails();
    }
}
