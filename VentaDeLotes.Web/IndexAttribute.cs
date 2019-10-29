using System;

namespace VentaDeLotes.Web
{
    internal class IndexAttribute : Attribute
    {
        private string v;
        private bool isUnique;

        public IndexAttribute(string v, bool IsUnique)
        {
            this.v = v;
            isUnique = IsUnique;
        }

        public bool IsUnique { get; set; }
    }
}