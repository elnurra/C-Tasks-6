using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForUsernamePassword
{
    class User
    {
        private string UserName ;
        private string Password ;
        public string _userName
        {
            get
            {
                return UserName;
            }
            set
            {
                if (value.Length>5 && value.Length<26)
                {
                    UserName = value;
                }
                else
                {
                    Console.WriteLine("Wrong input (lenthg) UserName: ");
                }
                           
            } 
            
        }
        public string _password 
        { 
            get 
            {
                return Password;
            }
            set
            {
                if (value.Length>7 && value.Length<26 && HasDigits(value) && HasLower(value) && HasUpper(value))
                {
                    
                    
                        Password=value;
                    
                    
                }
                else
                {
                    Console.WriteLine("Wrong input password: ");
                }
               

            }
         }
         
            private bool HasDigits(string hasdigits) 
            {

            foreach (char item in hasdigits)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }

            }
            
            return false;
        
             }
            private bool HasUpper(string hasupper) 
             {
            
            foreach (char item in hasupper)
            {
                if (char.IsUpper(item))
                {
                    return true;
                }

            }
            return false;
             }
            private bool HasLower(string haslower)
            {

            foreach (char item in haslower)
            {
                if (char.IsLower(item))
                {
                    return true;
                }

            }
            return false;
        }
        public void showInfo() 
        {
            Console.WriteLine($"Username: {UserName} \n Password: {Password} ");
        
        }
        


    }
    }


        //public int ChangeNumber { 
        //    set 
        //    {
        //        if (value > 0) 
        //        {
        //            Password = value;
        //        }
                
        //    } 
        //    get 
        //    {
                
        //        return Password;
        //    }
        //private int Password=48;

        //public void SetChangePassword(int number) 
        //{
        //    if (number>0)
        //    {
        //        Password = number;
        //    }
           
        
        //}
        //public int GetChangePassword()
        //{
        //    return Password;

        //}