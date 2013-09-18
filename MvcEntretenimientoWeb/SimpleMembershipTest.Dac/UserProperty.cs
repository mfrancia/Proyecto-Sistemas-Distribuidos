using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using MySql.Web.Security;

namespace SimpleMembershipTest.Dac
{
	/// <summary>
	/// UserProperty
	/// </summary>
	public class UserProperty : UserProfile
	{
		//[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		//public int UserId
		//{
		//	get;
		//	set;
		//}

		//public string UserName
		//{
		//	get;
		//	set;
		//}
		
		[DataType(DataType.EmailAddress)]
		public string Email
		{
			get;
			set;
		}

		public string Facebook
		{
			get;
			set;
		}

		public int? Age
		{
			get;
			set;
		}

		public double? Rate
		{
			get;
			set;
		}

		public string NoNombres
		{
			get;
			set;
		}

		public string NoApePaterno
		{
			get;
			set;
		}

        public string NoApeMaterno
        {
            get;
            set;
        }

        public int FlSexo
        {
            get;
            set;
        }


        public string CoTipoDocumento
        {
            get;
            set;
        }

        public string NuDocumento
        {
            get;
            set;
        }

        public string NoDireccion
        {
            get;
            set;
        }


        public string NuCelular
        {
            get;
            set;
        }
	}
}
