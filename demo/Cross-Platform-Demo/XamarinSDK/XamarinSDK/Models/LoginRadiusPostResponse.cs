﻿namespace XamarinSDK.Models
{
    public class LoginRadiusPostResponse
    {
        public bool IsPosted { get; set; }
    }
    public class LoginRadiusPostResponse<T>: LoginRadiusPostResponse
    {
        public T Data { get; set; }
    }
}
