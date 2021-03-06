﻿//------------------------------------------------------------------------------------------
// <author>Pablo Perdomo Falcón</author>
// <copyright file="User.cs" company="Pabllopf">GNU General Public License v3.0</copyright>
//------------------------------------------------------------------------------------------
namespace Utils.Data.Cloud
{
    /// <summary>User to save data.</summary>
    public class User
    {
        /// <summary>The name</summary>
        private string name = string.Empty;

        /// <summary>The password</summary>
        private string password = string.Empty;

        /// <summary>The access token</summary>
        private string accessToken = "jqOpre72KvAAAAAAAAAAFHzQGFGyrceq37MEZ1roiDyfvzEtLRyn65gfmXjzF3BA";

        /// <summary>Initializes a new instance of the <see cref="User"/> class.</summary>
        /// <param name="name">The name.</param>
        /// <param name="password">The password.</param>
        /// <param name="accessToken">The access token.</param>
        public User(string name, string password, string accessToken)
        {
            this.name = name;
            this.password = password;
            this.accessToken = accessToken;
        }

        /// <summary>Initializes a new instance of the <see cref="User"/> class.</summary>
        /// <param name="name">The name.</param>
        /// <param name="password">The password.</param>
        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        /// <summary>Initializes a new instance of the <see cref="User"/> class.</summary>
        public User()
        {
        }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        public string Name { get => name; set => name = value; }
        
        /// <summary>Gets or sets the password.</summary>
        /// <value>The password.</value>
        public string Password { get => password; set => password = value; }
        
        /// <summary>Gets or sets the access token.</summary>
        /// <value>The access token.</value>
        public string AccessToken { get => accessToken; set => accessToken = value; }
    }
}
