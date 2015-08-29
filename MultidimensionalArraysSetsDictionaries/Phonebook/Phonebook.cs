using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();

            while (true)
            {
                
                string input = Console.ReadLine();
                string[] contact;
                if (input != "search")
                {
                    
                    contact = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    string name = contact[0];
                    string phone = contact[1];

                    // in case of new contact
                    if (!phonebook.ContainsKey(name))
                    {
                        List<string> phoneNumbers = new List<string>();
                        phoneNumbers.Add(phone);

                        phonebook.Add(name, phoneNumbers);
                    }
                    else
                    {
                        // in case of new phone number for existing contact
                        if (!phonebook[name].Contains(phone))
                        {
                            phonebook[name].Add(phone);
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            
            while (true)
            {
                string contactName = Console.ReadLine();

                if (phonebook.ContainsKey(contactName))
                {
                    Console.WriteLine("{0} -> {1}", contactName, string.Join(", ", phonebook[contactName]));
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", contactName);
                }
            }
        }
    }
}
