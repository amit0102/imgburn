using System;
using System.Collections.Generic;
using System.Text;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices;

namespace BlueFlame.Classes
{
    public class ActiveDirectoryAuthentification
    {
        #region Static properties that hold the gathered data
        private static string _displayname = "";
        /// <summary>
        /// Returns the Username eg. 'John Doe'
        /// </summary>
        public static string DisplayName
        {
            get { return _displayname; }
        }

        private static string _accountName = "";
        /// <summary>
        /// Returns the account Name eg. 'm0012345'
        /// </summary>
        public static string AccountName
        {
            get { return _accountName; }
        }

        private static string _department;

        public static string Department
        {
            get { return _department; }
        }

        #endregion

        /// <summary>
        /// Authentificates a user in an active directory domain by checking for its sAMAccoutName. 
        /// If the User could be authenticated against the Domain the static fields of the class are 
        /// filled and can be accessed from the calling code level
        /// </summary>
        /// <param name="server">Name or address of the server, eg. 'domain.server.de'</param>
        /// <param name="domainName">Name of Userdomain, eg. 'DCS'</param>
        /// <param name="username">The username for to authenticate by its account name, eg. 'm0012345'</param>
        /// <param name="password">The password to authenticate with</param>
        /// <returns>True if the user could be authenticated against the domain, false if not or an error occured</returns>
        public static bool IsAuthentificated(string server, string domainName, string username, string password)
        {
            string authname = domainName + @"\" + username;
            
            // Create a searchfilter (LDAP specific)
            string searchfilter = "(&(sAMAccountName=" + username + "*)(objectClass=User))";

            // Create a directory context to gather domain information
            DirectoryContext directoryContext = new DirectoryContext(DirectoryContextType.Domain, server, authname, password);

            try
            {
                // Find the domain in the specified context
                Domain domain = Domain.GetDomain(directoryContext);

                // Fetch a domain controller
                DomainController controller = domain.FindDomainController();

                // Create Path for LDAP access
                string path = "LDAP://" + controller.Name + "/" + domain.GetDirectoryEntry().Properties["distinguishedName"][0].ToString();

                // Get an entry for the current directory
                DirectoryEntry rootEntry = new DirectoryEntry(path, authname, password);

                // Create a Searcher object to browse the directory
                DirectorySearcher searcher = new DirectorySearcher(rootEntry);

                // Find the properties Displayname, Group and Account Name
                searcher.PropertiesToLoad.Add("cn");
                searcher.PropertiesToLoad.Add("sAMAccountName");
                searcher.PropertiesToLoad.Add("department");

                // Apply the searchfilter to specifiy that the desired object is a user object
                searcher.Filter = searchfilter;

                // Execute the searcher
                SearchResult result = searcher.FindOne();

                // If the userobject could be found
                if (result != null)
                {
                    _accountName = result.Properties["sAMAccountName"][0].ToString();
                    _displayname = result.Properties["cn"][0].ToString();
                    _department = result.Properties["department"][0].ToString();

                    // Return that the user IsAuthenticated
                    return true;
                }
                else
                {
                    // Return that the user is not authenticated
                    return false;
                }
            }
            catch(ActiveDirectoryObjectNotFoundException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return false;
            }
            catch (ActiveDirectoryOperationException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return false;
            }
            catch (ActiveDirectoryServerDownException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
