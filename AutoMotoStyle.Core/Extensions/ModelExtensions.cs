using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using AutoMotoStyle.Core.Contracts;

namespace AutoMotoStyle.Core.Extensions
{
    public static class ModelExtensions
    {
        public static string GetInformation(this ICarModel car)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(car.Brand.Replace(" ", "-"));
            sb.Append("-");
            sb.Append(GetModel(car.Model));

            return sb.ToString();
        }

        private static string GetModel(string carModel)
        {
            string result = string
                .Join("-", carModel.Split(" ", StringSplitOptions.RemoveEmptyEntries).Take(2));

            return Regex.Replace(carModel, @"[^a-zA-Z0-9\-]", string.Empty);
        }
    }
}
