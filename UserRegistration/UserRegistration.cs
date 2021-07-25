using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;


namespace UserRegistration
{
   public class UserRegistration
    {
        public string CheckName(string name)
        {
            //pattern check first letter is capital with minimum of 3 letters
            string pattern = "^[A-Z][a-z]{2}[a-z]*$";
            Regex regex = new Regex(pattern);
            try
            {
                //if message is null throw Null exception
                if (name == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION, "Name should not be null");
                }
                //if name is empty throw Empty exception
                if (name == "")
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Name should not be empty");
                }
                if (regex.IsMatch(name))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            //return the message
            catch (NullReferenceException e)
            {
                return (e.Message);
            }
        }
        public string EmailCheck(string mail)
        {
            //email pattern first feild min 3 letter followed by @ then followed by word "." with com 
            string pattern = @"^[a-zA-Z]{3}([\- \+ _\.]*[a-zA-Z0-9]+)*@[a-zA-Z0-9]+\.[a-z]{2,3}(\.[a-zA-Z]{2,4}){0,1}$";
            Regex regex = new Regex(pattern);
            try
            {
                if (regex.IsMatch(mail))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception e)
            {
                return "Email should not be null";
            }
        }
        public string CheckMobileNumber(string number)
        {
            //mobile number begins with country code and 10 numbers separated by space
            string pattern = @"^[1-9]{2}\s[1-9][0-9]{9}$";
            Regex regex = new Regex(pattern);
            try
            {
                if (number == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION, "Number should not be null");
                }
                if (number == "")
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Number should not be empty");
                }
                if (regex.IsMatch(number))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }
        public string CheckPassword(string password)
        {
            //password contains
            //1.Atleast one capital and one small letter
            //2.Atleast one number
            //3.exactly one special char
            //4.minimum of 8 char
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$";
            Regex regex = new Regex(pattern);
            try
            {
                if (password == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION, "Password should not be null");
                }
                if (password == "")
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Password should not be empty");
                }
                if (regex.IsMatch(password))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }

        public static string TestUserRegistration(UserRegistrationAnnotation userRegistration)
        {
            //creating object for validation context and passing the validation class
            ValidationContext validationContext = new ValidationContext(userRegistration, null, null);
            //store the resukt of validation in list
            List<ValidationResult> validationResults = new List<ValidationResult>();
            //if all the result in lista re true 
            bool valid = Validator.TryValidateObject(userRegistration, validationContext, validationResults, true);
            try
            {
                //if any one is not valid then return the error message
                if (!valid)
                {
                    foreach (ValidationResult i in validationResults)
                    {
                        //throwing invalid extry exception in custom exception class
                        throw new CustomeException(CustomeException.ExceptionType.INVALID_ENTRY_EXCEPTION, "" + i.ToString());
                    }
                    throw new CustomeException(CustomeException.ExceptionType.NULL_FIELD_EXCEPTION, "No Field Found");
                }
                //else return validation satisfied
                else
                {
                    return "Happy";
                }
            }
            catch(Exception e)
            {
                return e.Message;
            }
            
        }
    }
}



