

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

using SoundShareHub.Models;
using SoundShareHub.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
//using System.Web.Http;
using Microsoft.AspNetCore.Mvc;

namespace SoundShareHub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserManagementController : ControllerBase
    {
        string username = "";
        int UserID = 0;

        private readonly ConnectionStringProvider _connectionStringProvider;

        public UserManagementController(ConnectionStringProvider connectionStringProvider)
        {
            _connectionStringProvider = connectionStringProvider;
        }

        [Route("api/createnewuser")]
        [HttpPost]
        public String CreateUser([FromBody] UserManagement um)
        {
            var GetVerifiedDate = new Helper();
            try
            {
                string connectionString = _connectionStringProvider.GetLocalConnectionString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SOUNDSHAREHUB_CreateNewUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = um.Username != null ? (object)um.Username : DBNull.Value; // Replace with actual values
                        command.Parameters.Add("@Firstname", SqlDbType.NVarChar).Value = um.FirstName != null ? (object)um.FirstName : DBNull.Value; // Replace with actual values
                        command.Parameters.Add("@Lastname", SqlDbType.NVarChar).Value = um.LastName != null ? (object)um.LastName : DBNull.Value; // Replace with actual values
                        command.Parameters.Add("@Issuperuser", SqlDbType.Bit).Value = um.isSuperUser != false ? (object)um.isSuperUser : DBNull.Value; // Replace with actual values
                        command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = um.Email != null ? (object)um.Email : DBNull.Value; // Replace with actual values
                        command.Parameters.Add("@Displayname", SqlDbType.NVarChar).Value = um.DisplayName != null ? (object)um.DisplayName : DBNull.Value; // Replace with actual values
                        command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = um.Password != null ? (object)um.Password : DBNull.Value; // Replace with actual values
                        command.Parameters.Add("@Phoneno", SqlDbType.NVarChar).Value = um.PhoneNo != null ? (object)um.PhoneNo : DBNull.Value; // Replace with actual values
                        command.Parameters.Add("@dob", SqlDbType.DateTime).Value = GetVerifiedDate.verifyDate(um.Dob); // Replace with actual values
                        command.Parameters.Add("@Lastipaddress", SqlDbType.NVarChar).Value = um.LastIPAddress != null ? (object)um.LastIPAddress : DBNull.Value; // Replace with actual values
                        command.Parameters.Add("@Isdeleted", SqlDbType.Bit).Value = um.IsDeleted != false ? (object)um.IsDeleted : DBNull.Value; // Replace with actual values
                        command.Parameters.Add("@Createdbyuserid", SqlDbType.Int).Value = 5; // Replace with actual values

                        command.ExecuteNonQuery();
                    }
                }
                return "success";
                //return Request.CreateResponse(HttpStatusCode.OK, new { Status = "Success", Message = "User inserted successfully." });
            }
            catch(Exception e) { }
            return "Failed";
            //return Request.CreateResponse(HttpStatusCode.InternalServerError,
               // new { Status = "Fail", Message = "Failed to Create new user." });
        }
    }
}
