﻿using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinSDK.Handler;
using XamarinSDK.LoginRadiusException;
using XamarinSDK.Models;

namespace XamarinSDK.Api.EmailPromptAutoLogin
{
    public  class EmailPromptAutoLoginByUsernameAPI
    {
        public static async Task GetEmailPromptAutoLoginByUsername(Dictionary<string, string> myDictionary, Action<LoginRadiusPostResponse> OnSuccess = null, Action<ErrorResponse> OnFailure = null)
        {
            var api = RestRequest.CallApi<ApiInterface>();

            try
            {
                String apikey = myDictionary["apikey"];
                String username = myDictionary["username"];
                String clientguid = myDictionary["clientguid"];
                String smartloginemailtemplate = "";
                String welcomeemailtemplate = "";
                String redirecturl = "";

                if (myDictionary.ContainsKey("smartloginemailtemplate"))
                {
                    smartloginemailtemplate = myDictionary["smartloginemailtemplate"];
                }
                if (myDictionary.ContainsKey("welcomeemailtemplate"))
                {
                    welcomeemailtemplate = myDictionary["welcomeemailtemplate"];
                }
                if (myDictionary.ContainsKey("redirecturl"))
                {
                    redirecturl = myDictionary["redirecturl"];
                }
                var response = await api.GetEmailPromptAutoLoginByUsername(apikey, username, clientguid, smartloginemailtemplate, welcomeemailtemplate, redirecturl);
                if (OnSuccess != null)
                {
                    OnSuccess(response);
                }
            }
            catch (ApiException ex)
            {
                var statusCode = ex.StatusCode;
                var error = ex.GetContentAs<ErrorResponse>();
                if (OnFailure != null) { }
                OnFailure(error);
            }


        }
    }
}
