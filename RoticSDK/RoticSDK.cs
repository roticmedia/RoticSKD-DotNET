﻿using Newtonsoft.Json;
using Rotic;
using System;
using System.Linq;

namespace Rotic
{
    public class RoticSDK
    {

        private string UniqueToken,Token,Api;

        public string Unique_Token
        {
            get
            {
                return UniqueToken;
            }
            set
            {
                UniqueToken = value;
            }
        }

        public string token
        {
            get
            {
                return Token;
            }
            set
            {
                Token = value;
            }
        }

        public string api
        {
            get
            {
                return Api;
            }
            set
            {
                Api = value;
            }
        }


        private static Random random = new Random();


        public RoticSDK()
        {
        }

        //public RoticSDKInitModel init(string unique_token=null)
        //{
        //    try
        //    {
        //        if (token != null & api != null)
        //        {
        //            string Result = Request.MakeRequest(this.token, this.api, unique_token != null ? unique_token : this.ut, "/init");

        //            RoticSDKInitModel response = JsonConvert.DeserializeObject<RoticSDKInitModel>(Result);
        //            bName = response.response.name;
        //            bDescription = response.response.description;
        //            bDomain = response.response.domain;
        //            bLogo = "https://rotic.ir/storage/enterprise_logo/" + response.response.enterprise_logo;

        //            return response;
        //        }
        //        else if(token == null){

        //            RoticSDKInitModel model = new RoticSDKInitModel();
        //            model.error.message = "Token not specified to the server!";
        //            model.error.code = 21;
        //            model.provider.source = "Rotic .NET SDK";
        //            model.provider.website = "https://rotic.ir";
        //            model.response = null;
        //            model.status = false;

        //            return model;
        //        }
        //        else if (api == null)
        //        {

        //            RoticSDKInitModel model = new RoticSDKInitModel();
        //            model.error.message = "Api Token not specified to the server!";
        //            model.error.code = 22;
        //            model.provider.source = "Rotic .NET SDK";
        //            model.provider.website = "https://rotic.ir";
        //            model.response = null;
        //            model.status = false;

        //            return model;
        //        }
        //        else
        //        {
        //            RoticSDKInitModel model = new RoticSDKInitModel();
        //            model.error.message = "Unknown error happened";
        //            model.error.code = 304;
        //            model.provider.source = "Rotic .NET SDK";
        //            model.provider.website = "https://rotic.ir";
        //            model.response = null;
        //            model.status = false;

        //            return model;
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        Console.WriteLine(e.Message);

        //        RoticSDKInitModel model = new RoticSDKInitModel();
        //        model.error.message = e.Message;
        //        model.error.code = e.HResult;
        //        model.provider.source = "Rotic .NET SDK";
        //        model.provider.website = "https://rotic.ir";
        //        model.response = null;
        //        model.status = false;

        //        return model;

        //    }
        //}

        public RoticSDKModel chat(string data, string unique_token = null)
        {
            try
            {
                if (Token!=null && Api !=null)
                {
                    RoticSDKModel response = Request.MakeRequestAsync(this.Token, this.Api, data, unique_token);
                    return response;
                }
                else
                {
                    RoticSDKModel model = new RoticSDKModel();
                    model.error.message = "Token or Api token did not valueted!";
                    model.error.code = 207;
                    model.provider.source = "Rotic .NET SDK";
                    model.provider.website = "https://rotic.ir";
                    model.response = null;
                    model.status = false;

                    return model;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

                RoticSDKModel model = new RoticSDKModel();
                model.error.message = e.Message;
                model.error.code = e.HResult;
                model.provider.source = "Rotic .NET SDK";
                model.provider.website = "https://rotic.ir";
                model.response = null;
                model.status = false;

                return model;

            }
        }
    }
}
