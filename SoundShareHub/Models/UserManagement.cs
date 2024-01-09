
/*
' Copyright (c) 2023 Alika Iwe
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

/*
' Copyright (c) 2023 Alika Iwe
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoundShareHub.Models
{
    public class UserManagement
    {
        [JsonProperty("userid")]
        public int UserID { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("confirmpassword")]
        public string ConfirmPassword { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("issuperuser")]
        public bool isSuperUser { get; set; }

        [JsonProperty("displayname")]
        public string DisplayName { get; set; }

        [JsonProperty("phoneno")]
        public string PhoneNo { get; set; }

        [JsonProperty("dob")]
        public DateTime Dob { get; set; }

        [JsonProperty("lastipaddress")]
        public string LastIPAddress { get; set; }

        [JsonProperty("isdeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("passwordresettoken")]
        public string PasswordResetToken { get; set; }

        [JsonProperty("passwordresetexpiration")]
        public DateTime PasswordResetExpiration { get; set; }

        [JsonProperty("createondate")]
        public DateTime CreatedOnDate { get; set; }

        [JsonProperty("createdbyuserid")]
        public int CreatedByUserId { get; set; }

        [JsonProperty("lastmodifiedondate")]
        public DateTime LastModifiedOnDate { get; set; }

        [JsonProperty("lastmodifiedbyuserid")]
        public int LastModifiedByUserId { get; set; }

        [JsonProperty("cookievalue")]
        public string CookieValue { get; set; }
    }
}
