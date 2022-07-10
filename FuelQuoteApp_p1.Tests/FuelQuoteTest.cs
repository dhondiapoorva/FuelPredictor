using FuelQuoteApp_p1.Controllers;
using FuelQuoteApp_p1.Models.Account;
using FuelQuoteApp_p1.Models.Client_Profile;

using Microsoft.AspNetCore.Identity;
using NUnit.Framework;
using System;

namespace FuelQuoteApp_p1.Tests
{
    [TestFixture]
    public class FuelQuoteTest
    {
        private readonly AccountController _controller;
        private readonly ClientController _controllerClient;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public FuelQuoteTest()
        {
            _controller = new AccountController(userManager, signInManager);
            _controllerClient = new ClientController();
        }


        [TestCase]
        public void RegisterUserNameValidationEmptyString()
        {
            //Hardcoding dummy user Info data
            Register registerinfo = new Register()
            {
                UserName = "",
                Email = "newuser1@gmail.com",
                Password = "Abcd1234",
                ConfirmPassword = "Abcd1234"
            };

            var result = _controller.RegisterDataValidation(registerinfo);

            //Check if all the validation passed
            Assert.False(result);

        }
        [TestCase]
        public void RegisterUserNameValidationLessthanChar()
        {
            //Hardcoding dummy user Info data
            Register registerinfo = new Register()
            {
                UserName = "hbfsbuawbdiubbjasbdjzskjcjbzhjcxbhzbhjcxbhbbzchjhbxzhbhevvasvdyuvwyuqvuqwvdubhbcabsahbchbasjkbchbczhjyvvasddavsdyvaty",
                Email = "newuser1@gmail.com",
                Password = "Abcd1234",
                ConfirmPassword = "Abcd1234"
            };

            var result = _controller.RegisterDataValidation(registerinfo);

            //Check if all the validation passed
            Assert.False(result);

        }
        [TestCase]
        public void RegisterEmailValidation_specialChar()
        {
            //Hardcoding dummy user Info data
            Register registerinfo = new Register()
            {
                UserName = "newuser1gmail.com",
                Email = "newuser1gmail.com",
                Password = "Abcd1234",
                ConfirmPassword = "Abcd1234"
            };

            var result = _controller.RegisterDataValidation(registerinfo);

            //Check if all the validation passed
            Assert.True(result);

        }
        [TestCase]
        public void RegisterEmailValidation_Empty()
        {
            //Hardcoding dummy user Info data
            Register registerinfo = new Register()
            {
                UserName = "newuser1@gmail.com",
                Email = "",
                Password = "Abcd1234",
                ConfirmPassword = "Abcd1234"
            };

            var result = _controller.RegisterDataValidation(registerinfo);

            //Check if all the validation passed
            Assert.False(result);

        }

        [TestCase]
        public void RegisterPasswordValidation()
        {
            //Hardcoding dummy user Info data
            Register registerinfo = new Register()
            {
                UserName = "newuser",
                Email = "newuser1@gmail.com",
                Password = "Abcd1234",
                ConfirmPassword = "Abcd1234"
            };

            var result = _controller.RegisterDataValidation(registerinfo);

            //Check if all the validation passed
            Assert.True(result);

        }

        [TestCase]
        public void RegisterConfirmPasswordValidation()
        {
            //Hardcoding dummy user Info data
            Register registerinfo = new Register()
            {
                UserName = "newuser",
                Email = "newuser1@gmail.com",
                Password = "Abcd1234",
                ConfirmPassword = "" // giving invalid password for testing purpose
            };

            var result = _controller.RegisterDataValidation(registerinfo);

            //Check if all the validation passed
            Assert.False(result);

        }

        [TestCase]
        public void ClientFullNameValidation_1()
        {
            //Hardcoding dummy user Info data
            Profile clientProfile = new Profile()
            {
                Address1 = "Kirby Drive",
                Address2 = "Apt 1206",
                City = "Houston",
                FullName = "Sai",
                State = States.TX,
                ZipCode = "77054"
            };

            var result = _controllerClient.ClientProfileDataValidation(clientProfile);

            //Check if all the validation passed
            Assert.True(result);

        }
        [TestCase]
        public void ClientFullNameValidation_2()
        {
            //Hardcoding dummy user Info data
            Profile clientProfile = new Profile()
            {
                Address1 = "Kirby Drive",
                Address2 = "Apt 1206",
                City = "Houston",
                FullName = "",
                State = States.TX,
                ZipCode = "77054"
            };

            var result = _controllerClient.ClientProfileDataValidation(clientProfile);

            //Check if all the validation passed
            Assert.False(result);

        }
        [TestCase]
        public void ClientFullNameValidation_3()
        {
            //Hardcoding dummy user Info data
            Profile clientProfile = new Profile()
            {
                Address1 = "Kirby Drive",
                Address2 = "Apt 1206",
                City = "Houston",
                FullName = "asbshbdfkjefeiwbfsnfksnfknuewonfksngdkndkjbkwebukbkubsekjfbjbdsjkzbjbsjkbcsjsbfbebsfusbdvubui",
                State = States.TX,
                ZipCode = "77054"
            };

            var result = _controllerClient.ClientProfileDataValidation(clientProfile);

            //Check if all the validation passed
            Assert.False(result);

        }

        [TestCase]
        public void ClientAddressValidation()
        {
            //Hardcoding dummy user Info data
            Profile clientProfile = new Profile()
            {
                Address1 = "",
                Address2 = "Apt 1206",
                City = "Houston",
                FullName = "Sai", 
                State = States.TX,
                ZipCode = "77054"
            };

            var result = _controllerClient.ClientProfileDataValidation(clientProfile);

            //Check if all the validation passed
            Assert.False(result);

        }

        [TestCase]
        public void Client_Address_city_Validation_Empty()
        {
            //Hardcoding dummy user Info data
            Profile clientProfile = new Profile()
            {
                Address1 = "hjjhbj",
                Address2 = "Apt 1206",
                City = "",
                FullName = "Sai",
                State = States.TX,
                ZipCode = "77054"
            };

            var result = _controllerClient.ClientProfileDataValidation(clientProfile);

            //Check if all the validation passed
            Assert.False(result);

        }
        [TestCase]
        public void Client_Address_city_Validation_Exceed()
        {
            //Hardcoding dummy user Info data
            Profile clientProfile = new Profile()
            {
                Address1 = "hjjhbj",
                Address2 = "Apt 1206",
                City = "ahbshjbahdahbhbbahbschvhjvejvfhjavhcvhjavchvhvhvewhvvhjavcjvhvhvvwejvfyvdcjhbcbweufubuwebcesbjbcjbewjfsjbcjbhs",
                FullName = "Sai",
                State = States.TX,
                ZipCode = "77054"
            };

            var result = _controllerClient.ClientProfileDataValidation(clientProfile);

            //Check if all the validation passed
            Assert.False(result);

        }


        [TestCase]
        public void ClientZipCodeValidation()
        {
            //Hardcoding dummy user Info data
            Profile clientProfile = new Profile()
            {
                Address1 = "Kirby Drive",
                Address2 = "Apt 1206",
                City = "Houston",
                FullName = "Sai",
                State = States.TX,
                ZipCode = "1216165616513" //passing invalid zipcode
            };

            var result = _controllerClient.ClientProfileDataValidation(clientProfile);

            //Check if all the validation passed
            Assert.False(result);

        }
        [TestCase]
        public void ClientZipCodeValidation_True()
        {
            //Hardcoding dummy user Info data
            Profile clientProfile = new Profile()
            {
                Address1 = "Kirby Drive",
                Address2 = "Apt 1206",
                City = "Houston",
                FullName = "Sai",
                State = States.TX,
                ZipCode = "77054" //passing valid zipcode
            };

            var result = _controllerClient.ClientProfileDataValidation(clientProfile);

            //Check if all the validation passed
            Assert.True(result);

        }

    }
}
