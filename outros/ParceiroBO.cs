using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.sotisolutions.khronus.dal.dbo;
using System.Data;

namespace Khronus.Framework.Test
{
    [TableAttr("baaj")]
    public class ParceiroBO : BusinessObjectBase
    {
        [FieldAttr]
        [KeyAttr]
        public int BAAJ_COD_FILIAL { get; set; }

        [@FieldAttr]
        [KeyAttr]
        public int BAAJ_CODIGO { get; set; }

        [@FieldAttr]
        //[KeyAttr]
        public String BAAJ_TIPO { get; set; }

        [@FieldAttr]
        public String BAAJ_NOME_FANT { get; set; }

        [@FieldAttr]
        public String BAAJ_TIPO_PESSOA { get; set; }

        [@FieldAttr]
        public String BAAJ_CNPJ_CPF_ID { get; set; }

        [@FieldAttr]
        public String BAAJ_IE_RG { get; set; }

        [@FieldAttr]
        public String BAAJ_IM { get; set; }

        [@FieldAttr]
        public String BAAJ_ISUF { get; set; }

        [@FieldAttr]
        public String BAAJ_CNAE { get; set; }

        [@FieldAttr]
        public String BAAJ_RAZAO_SOCIAL { get; set; }

        [@FieldAttr]
        [IsForeignKey]
        public int? BAAJ_COD_CEP { get; set; }

        [@FieldAttr]
        public String BAAJ_NUMERO { get; set; }

        [@FieldAttr]
        public String BAAJ_COMPL { get; set; }

        [@FieldAttr]
        public String BAAJ_FONE1 { get; set; }

        [@FieldAttr]
        public String BAAJ_FONE2 { get; set; }

        [@FieldAttr]
        public String BAAJ_CEL { get; set; }

        [Column("BAAJ_EMAIL", true, false, DbType.String)]
        public String BAAJ_EMAIL { get; set; }

        [@FieldAttr]
        public String BAAJ_EMAIL_NFE { get; set; }

        [@FieldAttr]
        public String BAAJ_CRT { get; set; }

        [@FieldAttr]
        public int? BAAJ_COD_CEP_ENTR { get; set; }

        [@FieldAttr]
        public String BAAJ_NUMERO_ENTR { get; set; }

        [@FieldAttr]
        public String BAAJ_COMPL_ENTR { get; set; }

        [@FieldAttr]
        public int? BAAJ_COD_CEP_FATU { get; set; }

        [@FieldAttr]
        public String BAAJ_NUMERO_FATU { get; set; }

        [@FieldAttr]
        public String BAAJ_COMPL_FATU { get; set; }

        [@FieldAttr]
        public float BAAJ_LIMITE_CRED { get; set; }

        [IsNull]
        [@FieldAttr]
        public String BAAJ_CERTIFICADO_NOME { get; set; }

        [IsNull]
        [@FieldAttr]
        public String BAAJ_CERTIFICADO_SENHA { get; set; }

        [IsNull]
        [@FieldAttr]
        public String BAAJ_IMAGEM { get; set; }

        [@FieldAttr]
        [IsForeignKey]
        [IsNull]
        public int? BAAJ_COD_SEGMENTO { get; set; }

        [@FieldAttr]
        public String BAAJ_CONTATO_01_NOME { get; set; }

        [@FieldAttr]
        public String BAAJ_CONTATO_01_DEPTO { get; set; }

        [@FieldAttr]
        public String BAAJ_CONTATO_01_EMAIL { get; set; }

        [@FieldAttr]
        public String BAAJ_CONTATO_01_FONE { get; set; }

        [@FieldAttr]
        public String BAAJ_CONTATO_02_NOME { get; set; }

        [@FieldAttr]
        public String BAAJ_CONTATO_02_DEPTO { get; set; }

        [@FieldAttr]
        public String BAAJ_CONTATO_02_EMAIL { get; set; }

        [@FieldAttr]
        public String BAAJ_CONTATO_02_FONE { get; set; }

        [@FieldAttr]
        public String BAAJ_CONTATO_03_NOME { get; set; }

        [@FieldAttr]
        public String BAAJ_CONTATO_03_DEPTO { get; set; }

        [@FieldAttr]
        public String BAAJ_CONTATO_03_EMAIL { get; set; }

        [@FieldAttr]
        public String BAAJ_CONTATO_03_FONE { get; set; }

        [@FieldAttr]
        public int? BAAJ_FIN_COD_BANCO { get; set; }

        [@FieldAttr]
        public String BAAJ_FIN_AGENCIA { get; set; }

        [@FieldAttr]
        public String BAAJ_FIN_CONTA { get; set; }

        [@FieldAttr]
        public float? BAAJ_FIN_COMISSAO { get; set; }

        [@FieldAttr]
        public String BAAJ_PRO_CTPS_NUM { get; set; }

        [@FieldAttr]
        public String BAAJ_PRO_CTPS_SERIE { get; set; }

        [@FieldAttr]
        public DateTime? BAAJ_PRO_CTPS_DT_EMISSAO { get; set; }

        [@FieldAttr]
        public DateTime? BAAJ_PRO_DT_ADMISSAO { get; set; }

        [@FieldAttr]
        public DateTime? BAAJ_PRO_DT_DEMISSAO { get; set; }

        [@FieldAttr]
        public int? BAAJ_PRO_COD_CARGO { get; set; }

        [@FieldAttr]
        public String BAAJ_PES_SEXO { get; set; }

        [@FieldAttr]
        public String BAAJ_PES_EST_CIVIL { get; set; }

        [@FieldAttr]
        public DateTime? BAAJ_PES_DT_NASC { get; set; }

        [IsNull]
        [@FieldAttr]
        public String BAAJ_INDIEDEST { get; set; }

        [@FieldAttr]
        public bool BAAJ_PADRAO { get; set; }

        [@FieldAttr]
        public String BAAJ_USU_ULT_ALT { get; set; }

        [@FieldAttr]
        public DateTime BAAJ_DAT_ULT_ALT { get; set; }

        [@FieldAttr]
        public bool BAAJ_INATIVO { get; set; }
    }
}
