using System;

namespace APIGeo
{
    internal class CorsAuthorizationFilterFactory : Type
    {
        private string v;

        public CorsAuthorizationFilterFactory(string v)
        {
            this.v = v;
        }
    }
}