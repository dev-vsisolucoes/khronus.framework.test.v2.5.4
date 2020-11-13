using com.sotisolutions.khronus.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using com.sotisolutions.khronus.dal.dbo;
using com.sotisolutions.khronus;
using com.sotisolutions.khronus.dal;

/// <summary>
/// Summary description for NotaFiscalBO
/// </summary>
[TableAttr("veau")]
public class NotaFiscalBO: BusinessObjectBase
{
    public const String NOTA_FISCAL_DEST_TIPO_JURIDICO = "J";
    public const String NOTA_FISCAL_DEST_TIPO_FISICO = "F";

    public const String NOTA_FISCAL_TRANSP_TIPO_JURIDICO = "J";
    public const String NOTA_FISCAL_TRANSP_TIPO_FISICO = "F";

    public const String NOTA_FISCAL_STATUS_ABERTA = "AB";
    public const String NOTA_FISCAL_STATUS_PROCESSADA = "PR";
    public const String NOTA_FISCAL_STATUS_FINALIZADA = "FI";
    public const String NOTA_FISCAL_STATUS_CANCELADA = "CA";


    [@FieldAttr]
    [KeyAttr]
    public int VEAU_COD_FILIAL { get; set; }

    [@FieldAttr]
    [KeyAttr]
    public int VEAU_CODIGO { get; set; }


    [@FieldAttr]
    [IsForeignKey]
    [IsNull]
    public int? VEAU_COD_NAT_OPER { get; set; }


    [@FieldAttr]
    [IsForeignKey]
    [IsNull]
    public int? VEAU_COD_PEDIDO { get; set; }


    [@FieldAttr]
    public String VEAU_INFNFE_IDE_CUF { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_CNF { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_NATOPER { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_INDPAG { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_MOD { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_SERIE { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_NNF { get; set; }

    [@FieldAttr]
    public DateTime VEAU_INFNFE_IDE_DHEMI { get; set; }

    [@FieldAttr]
    public DateTime VEAU_INFNFE_IDE_DHSAIENT { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_TPNF { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_IDDEST { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_CMUNFG { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_TPIMP { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_TPEMIS { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_CDV { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_TPAMB { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_FINNFE { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_INDFINAL { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_INDPRES { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_PROCEMI { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_VERPROC { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_IDE_IDNFE { get; set; }

    [@FieldAttr]
    [IsForeignKey]
    [IsNull]
    public int? VEAU_INFNFE_EMIT_COD_PARC { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_CNPJ_CPF { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_XNOME { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_XFANT { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_XLGR { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_NRO { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_XCPL { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_XBAIRRO { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_CMUN { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_XMUN { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_UF { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_CEP { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_CPAIS { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_XPAIS { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_FONE { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_IE { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_IEST { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_IM { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_CNAE { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_EMIT_CRT { get; set; }


    [@FieldAttr]
    [IsForeignKey]
    [IsNull]
    public int? VEAU_INFNFE_DEST_COD_PARC { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_TIPO { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_CNPJ_CPF_ID { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_XNOME { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_XLGR { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_NRO { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_XCPL { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_XBAIRRO { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_CMUN { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_XMUN { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_UF { get; set; }

    //[@FieldAttr]
    //public String VEAU_INFNFE_DEST_CUF { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_CEP { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_CPAIS { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_XPAIS { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_FONE { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_INDIEDEST { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_IE { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_ISUF { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_IM { get; set; }

    [@FieldAttr]
    public String VEAU_INFNFE_DEST_EMAIL { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VBC { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VICMS { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VICMSDESON { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VFCPUFDEST { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VICMSUFDEST { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VICMSUFREMET { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VBCST { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VST { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VPROD { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VFRETE { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VSEG { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VDESC { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VII { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VIPI { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VPIS { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VCOFINS { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VOUTRO { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VNF { get; set; }

    [@FieldAttr]
    public decimal VEAU_INFNFE_TOTAL_VTOTTRIB { get; set; }

    /*
     * Transp
     */

    [@FieldAttr]
    public String VEAU_INFNFE_TRANSP_MODFRETE { get; set; }


    [@FieldAttr]
    [IsForeignKey]
    [IsNull]
    public int? VEAU_INFNFE_TRANSP_COD_TRANSP { get; set; }


    [@FieldAttr]
    [IsNull]
    public String VEAU_INFNFE_TRANSP_TIPO { get; set; }


    [@FieldAttr]
    [IsNull]
    public String VEAU_INFNFE_TRANSP_CNPJ_CPF { get; set; }


    [@FieldAttr]
    [IsNull]
    public String VEAU_INFNFE_TRANSP_XNOME { get; set; }


    [@FieldAttr]
    [IsNull]
    public String VEAU_INFNFE_TRANSP_IE { get; set; }


    [@FieldAttr]
    [IsNull]
    public String VEAU_INFNFE_TRANSP_XENDER { get; set; }


    [@FieldAttr]
    [IsNull]
    public String VEAU_INFNFE_TRANSP_XMUN { get; set; }


    [@FieldAttr]
    [IsNull]
    public String VEAU_INFNFE_TRANSP_UF { get; set; }


    [@FieldAttr]
    [IsNull]
    public String VEAU_INFNFE_TRANSP_VEIC_PLACA { get; set; }


    [@FieldAttr]
    [IsNull]
    public String VEAU_INFNFE_TRANSP_VEIC_UF { get; set; }


    [@FieldAttr]
    [IsNull]
    public String VEAU_INFNFE_TRANSP_VEIC_RNTC { get; set; }


    [@FieldAttr]
    [IsNull]
    public int VEAU_INFNFE_TRANSP_VOL_QVOL { get; set; }


    [@FieldAttr]
    [IsNull]
    public String VEAU_INFNFE_TRANSP_VOL_ESP { get; set; }


    [@FieldAttr]
    [IsNull]
    public String VEAU_INFNFE_TRANSP_VOL_MARCA { get; set; }


    [@FieldAttr]
    [IsNull]
    public int VEAU_INFNFE_TRANSP_VOL_NVOL { get; set; }


    [@FieldAttr]
    [IsNull]
    public decimal VEAU_INFNFE_TRANSP_VOL_PESOL { get; set; }


    [@FieldAttr]
    [IsNull]
    public decimal VEAU_INFNFE_TRANSP_VOL_PESOB { get; set; }


    [@FieldAttr]
    [IsNull]
    public String VEAU_INFNFE_INFADC_INFCPL { get; set; }

    //Protocolo
    //[@FieldAttr]
    //public String VEAU_PROTNFE_VERSAO { get; set; }


    [@FieldAttr]
    public String VEAU_PROTNFE_INFPROT_TPAMB { get; set; }

    [@FieldAttr]
    public String VEAU_PROTNFE_INFPROT_VERAPLIC { get; set; }

    [@FieldAttr]
    public String VEAU_PROTNFE_INFPROT_CHNFE { get; set; }

    [@FieldAttr]
    public String VEAU_PROTNFE_INFPROT_DHRECBTO { get; set; }

    [@FieldAttr]
    public String VEAU_PROTNFE_INFPROT_NPROT { get; set; }

    [@FieldAttr]
    public String VEAU_PROTNFE_INFPROT_DIGVAL { get; set; }

    [@FieldAttr]
    public String VEAU_PROTNFE_INFPROT_CSTAT { get; set; }

    [@FieldAttr]
    public String VEAU_PROTNFE_INFPROT_XMOTIVO { get; set; }

    [@FieldAttr]
    public String VEAU_CORRECOES { get; set; }

    [@FieldAttr]
    public String VEAU_MOTIVO_CANCELAMENTO { get; set; }

    [@FieldAttr]
    public String VEAU_USU_ULT_ALT { get; set; }

    [@FieldAttr]
    public DateTime VEAU_DAT_ULT_ALT { get; set; }

    [@FieldAttr]
    public String VEAU_STATUS { get; set; }

    // List<NotaFiscalItemBO> notaFiscalItemBOList = new List<NotaFiscalItemBO>();

    //public List<NotaFiscalItemBO> NotaFiscalItemBOList {
    //    get
    //    {

    //    }
    //    set
    //    {

    //    }
    //}

    //private List<NotaFiscalCobrancaBO> notaFiscalCobrancaBOList = new List<NotaFiscalCobrancaBO>();

    //private List<NotaFiscalNfReferenciadaBO> notaFiscalNfReferenciadaBOList = new List<NotaFiscalNfReferenciadaBO>();
    
    //public NotaFiscalBO()
    //{
    //    //
    //    // TODO: Add constructor logic here
    //    //
    //}

    //public static NotaFiscalBO getInstance()
    //{
    //    return new NotaFiscalBO();
    //}

    //public List<NotaFiscalItemBO> getNotaFiscalItemBOList()
    //{
    //    return notaFiscalItemBOList;
    //}

    //public List<NotaFiscalCobrancaBO> getNotaFiscalCobrancaBOList()
    //{
    //    return notaFiscalCobrancaBOList;
    //}

    //public List<NotaFiscalNfReferenciadaBO> getNotaFiscalNfReferenciadaBO()
    //{
    //    return notaFiscalNfReferenciadaBOList;
    //}

    //public bool insert()
    //{
    //    return insert(this);
    //}

    //public bool insert(NotaFiscalBO bo)
    //{
    //    bo.VEAU_CODIGO = GatUtilities.getNumerator(bo.VEAU_COD_FILIAL, this.GetType().Name);
    //    bo.VEAU_INFNFE_IDE_CNF = bo.VEAU_CODIGO.ToString();

    //    if (bo.VEAU_INFNFE_IDE_NNF ==null || bo.VEAU_INFNFE_IDE_NNF.Equals("0") || bo.VEAU_INFNFE_IDE_NNF.Equals(String.Empty))
    //    {
    //        //bo.VEAU_INFNFE_IDE_NNF = GatUtilities.getNumerator(bo.VEAU_COD_FILIAL, "NotaFiscalNumero").ToString();
    //        //bo.VEAU_INFNFE_IDE_NNF = ParametroBO.getInstance().find(bo.VEAU_COD_FILIAL, "").XV_VALOR;
    //        bo.VEAU_INFNFE_IDE_NNF = GatUtilities.getNumerator(bo.VEAU_COD_FILIAL, "NotaFiscalNumero").ToString();
    //    }

    //    bo.VEAU_USU_ULT_ALT = StringUtilities.toString(HttpContext.Current.Session["USUARIO"]);
    //    bo.VEAU_DAT_ULT_ALT = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

    //    bool ret = DataAccessLayerManager.getInstance().insert(bo);

    //    foreach (NotaFiscalItemBO notaFiscalItemBO in notaFiscalItemBOList)
    //    {
    //        notaFiscalItemBO.VEAV_COD_FILIAL = bo.VEAU_COD_FILIAL;
    //        notaFiscalItemBO.VEAV_COD_NOTA = bo.VEAU_CODIGO;
    //        ret = notaFiscalItemBO.insert();

    //        if (!ret)
    //        {
    //            break;
    //        }
    //    }

    //    foreach (NotaFiscalCobrancaBO notaFiscalCobrancaBO in notaFiscalCobrancaBOList)
    //    {
    //        notaFiscalCobrancaBO.VEAW_COD_FILIAL = bo.VEAU_COD_FILIAL;
    //        notaFiscalCobrancaBO.VEAW_COD_NOTA = bo.VEAU_CODIGO;
    //        notaFiscalCobrancaBO.VEAW_DUP_NDUP = bo.VEAU_INFNFE_IDE_NNF + "/" + notaFiscalCobrancaBO.VEAW_ITEM;
    //        ret = notaFiscalCobrancaBO.insert();

    //        if (!ret)
    //        {
    //            break;
    //        }
    //    }

    //    foreach (NotaFiscalNfReferenciadaBO notaFiscalNfReferenciadaBO in notaFiscalNfReferenciadaBOList)
    //    {
    //        notaFiscalNfReferenciadaBO.VEAX_COD_NOTA = bo.VEAU_CODIGO;
    //        ret = notaFiscalNfReferenciadaBO.insert();

    //        if (!ret)
    //        {
    //            break;
    //        }
    //    }

    //    return ret;
    //}

    //public bool update()
    //{
    //    return update(this);
    //}

    //public bool update(NotaFiscalBO bo)
    //{
    //    bo.VEAU_USU_ULT_ALT = StringUtilities.toString(HttpContext.Current.Session["USUARIO"]);
    //    bo.VEAU_DAT_ULT_ALT = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

    //    bool ret = DataAccessLayerManager.getInstance().update(bo);

    //    if (ret)
    //    {
    //        DataTable dataTable = NotaFiscalItemBO.getInstance().getList(VEAU_COD_FILIAL, VEAU_CODIGO);
    //        foreach (DataRow row in dataTable.Rows)
    //        {
    //            NotaFiscalItemBO notaFiscalItemBO1 = NotaFiscalItemBO.getInstance().find(
    //                NumberUtilities.parseInt(row["VEAV_COD_FILIAL"]),
    //                NumberUtilities.parseInt(row["VEAV_COD_NOTA"]),
    //                NumberUtilities.parseInt(row["VEAV_ITEM"]));

    //            bool match = false;

    //            //for (int x = 0; x < notaFiscalItemBOList.Count; x++)
    //            while (notaFiscalItemBOList.Count > 0)
    //            {
    //                //NotaFiscalItemBO notaFiscalItemBO2 = notaFiscalItemBOList[x];
    //                NotaFiscalItemBO notaFiscalItemBO2 = notaFiscalItemBOList[0];

    //                if (notaFiscalItemBO1.VEAV_ITEM == notaFiscalItemBO2.VEAV_ITEM)
    //                {
    //                    match = true;

    //                    ret = notaFiscalItemBO2.update();

    //                    if (!ret)
    //                    {
    //                        break;
    //                    }

    //                    notaFiscalItemBOList.Remove(notaFiscalItemBO2);
    //                }
    //                else
    //                {
    //                    break;
    //                }
    //            }

    //            if (ret)
    //            {
    //                if (!match)
    //                {
    //                    notaFiscalItemBO1.delete();
    //                }
    //            }
    //        }

    //        if (ret)
    //        {
    //            foreach (NotaFiscalItemBO notaFiscalItemBO in notaFiscalItemBOList)
    //            {
    //                notaFiscalItemBO.VEAV_COD_NOTA = bo.VEAU_CODIGO;
    //                ret = notaFiscalItemBO.insert();

    //                if (!ret)
    //                {
    //                    break;
    //                }
    //            }

    //            DataTable dataTable1 = NotaFiscalCobrancaBO.getInstance().getList(VEAU_COD_FILIAL, VEAU_CODIGO);
    //            foreach (DataRow row in dataTable1.Rows)
    //            {
    //                NotaFiscalCobrancaBO notaFiscalCobrancaBO1 = NotaFiscalCobrancaBO.getInstance().find(
    //                    NumberUtilities.parseInt(row["VEAW_COD_FILIAL"]),
    //                    NumberUtilities.parseInt(row["VEAW_COD_NOTA"]),
    //                    NumberUtilities.parseInt(row["VEAW_ITEM"]));

    //                bool match = false;

    //                //for (int x = 0; x < notaFiscalCobrancaBOList.Count; x++)
    //                while(notaFiscalCobrancaBOList.Count>0)
    //                {
    //                    //NotaFiscalCobrancaBO notaFiscalCobrancaBO2 = notaFiscalCobrancaBOList[x];
    //                    NotaFiscalCobrancaBO notaFiscalCobrancaBO2 = notaFiscalCobrancaBOList[0];

    //                    if (notaFiscalCobrancaBO1.VEAW_ITEM == notaFiscalCobrancaBO2.VEAW_ITEM)
    //                    {
    //                        match = true;

    //                        ret = notaFiscalCobrancaBO2.update();

    //                        if (!ret)
    //                        {
    //                            break;
    //                        }

    //                        notaFiscalCobrancaBOList.Remove(notaFiscalCobrancaBO2);
    //                    }
    //                    else
    //                    {
    //                        break;
    //                    }
    //                }

    //                if (ret)
    //                {
    //                    if (!match)
    //                    {
    //                        notaFiscalCobrancaBO1.delete();
    //                    }
    //                }
    //            }
    //        }

    //        if (ret)
    //        {
    //            foreach (NotaFiscalCobrancaBO notaFiscalCobrancaBO in notaFiscalCobrancaBOList)
    //            {
    //                notaFiscalCobrancaBO.VEAW_COD_NOTA = bo.VEAU_CODIGO;

    //                ret = notaFiscalCobrancaBO.insert();

    //                if (!ret)
    //                {
    //                    break;
    //                }
    //            }
    //        }

    //        /*
    //         * Nota referenciada
    //         */
    //        if (ret)
    //        {
    //            DataTable dataTable1 = NotaFiscalNfReferenciadaBO.getInstance().getList(VEAU_COD_FILIAL, VEAU_CODIGO);
    //            foreach (DataRow row in dataTable1.Rows)
    //            {
    //                NotaFiscalNfReferenciadaBO notaFiscalNfReferenciadaBO1 = NotaFiscalNfReferenciadaBO.getInstance().find(
    //                    NumberUtilities.parseInt(row["VEAX_COD_FILIAL"]),
    //                    NumberUtilities.parseInt(row["VEAX_COD_NOTA"]),
    //                    NumberUtilities.parseInt(row["VEAX_ITEM"]));

    //                bool match = false;

    //                while (notaFiscalNfReferenciadaBOList.Count > 0)
    //                {
    //                    NotaFiscalNfReferenciadaBO notaFiscalNfReferenciadaBO2 = notaFiscalNfReferenciadaBOList[0];

    //                    if (notaFiscalNfReferenciadaBO1.VEAX_ITEM == notaFiscalNfReferenciadaBO2.VEAX_ITEM)
    //                    {
    //                        match = true;

    //                        ret = notaFiscalNfReferenciadaBO2.update();

    //                        if (!ret)
    //                        {
    //                            break;
    //                        }

    //                        notaFiscalNfReferenciadaBOList.Remove(notaFiscalNfReferenciadaBO2);
    //                    }
    //                    else
    //                    {
    //                        break;
    //                    }
    //                }

    //                if (ret)
    //                {
    //                    if (!match)
    //                    {
    //                        notaFiscalNfReferenciadaBO1.delete();
    //                    }
    //                }
    //            }
    //        }

    //        if (ret)
    //        {
    //            foreach (NotaFiscalNfReferenciadaBO notaFiscalNfReferenciadaBO in notaFiscalNfReferenciadaBOList)
    //            {
    //                notaFiscalNfReferenciadaBO.VEAX_COD_NOTA = bo.VEAU_CODIGO;
    //                ret = notaFiscalNfReferenciadaBO.insert();

    //                if (!ret)
    //                {
    //                    break;
    //                }
    //            }
    //        }
    //    }

    //    return ret;
    //}

    //public bool delete()
    //{
    //    return delete(this);
    //}

    //public bool delete(NotaFiscalBO bo)
    //{
    //    return DataAccessLayerManager.getInstance().delete(bo);
    //}

    ////public NotaFiscalBO find(int param1, int param2, String param3)
    //public NotaFiscalBO find(int param1, int param2)
    //{
    //    //return (NotaFiscalBO)DataAccessLayerManager.getInstance().find(this, new Object[,] { { "VEAU_COD_FILIAL", param1 }, { "VEAU_CODIGO", param2 }, { "VEAU_TIPO", "'" + param3 + "'"} });
    //    return (NotaFiscalBO)DataAccessLayerManager.getInstance().find(this, new Object[,] { { "VEAU_COD_FILIAL", param1 }, { "VEAU_CODIGO", param2 } });
    //}

    //public DataTable getList(int param1)
    //{
    //    return (DataTable)DataAccessLayerManager.getInstance().getList(this, new Object[,] { { "VEAU_COD_FILIAL", param1 } });
    //}

    //public DataTable getList(int param1, String param2, String param3, String param4, int pageNumber, int pageSize)
    //{
    //    String filter1 = param3 != null  ? " AND " + param2.Replace("value", param3) : String.Empty;

    //    String filter2 = param4 != null && !param4.Equals(String.Empty) ? " AND " + param4 : String.Empty;

    //    String sql = "SELECT * ";

    //    if (DataAccessLayerManager.getInstance().ConnectionProvider == DataAccessLayerManager.ConnectionProviders.SQLSERVER)
    //    {
    //        sql += "FROM (SELECT ROW_NUMBER() OVER(ORDER BY VEAU_INFNFE_IDE_NNF DESC) AS NUMBER, VEAU_COD_FILIAL, VEAU_CODIGO, VEAU_COD_PEDIDO, VEAU_INFNFE_IDE_CNF, VEAU_INFNFE_IDE_NNF, VEAU_INFNFE_IDE_SERIE, CASE VEAU_INFNFE_IDE_TPNF WHEN 0 THEN 'Entrada' ELSE 'Saida' END AS VEAU_INFNFE_IDE_TPNF, VEAU_INFNFE_IDE_DHEMI, VEAU_INFNFE_IDE_NATOPER, VEAU_INFNFE_EMIT_XNOME, VEAU_INFNFE_DEST_XNOME, VEAU_INFNFE_TOTAL_VNF, VEAU_PROTNFE_INFPROT_CSTAT, VEAU_PROTNFE_INFPROT_XMOTIVO, VEAU_PROTNFE_INFPROT_TPAMB, VEAU_STATUS ";
    //        sql += "FROM veau ";
    //        sql += "WHERE VEAU_COD_FILIAL = " + param1 + filter1 + filter2;
    //        sql += ") AS veau ";

    //        if (pageSize != 0) { sql += "WHERE NUMBER BETWEEN " + (pageNumber != 0 ? pageNumber + 1 : pageNumber) + " AND " + ((pageNumber != 0 ? pageNumber + 1 : pageNumber) + pageSize) + " "; }

    //    }
    //    else if (DataAccessLayerManager.getInstance().ConnectionProvider == DataAccessLayerManager.ConnectionProviders.MYSQL)
    //    {
    //        sql += "FROM veau ";
    //        sql += "WHERE VEAU_COD_FILIAL = " + param1 + filter1 + filter2;
    //    }

    //    return DataAccessLayerManager.getInstance().getListBySelect(sql);
    //}

    //public int getListCount(int param1, String param2, String param3, String param4)
    //{
    //    String filter1 = param3 != null  ? " AND " + param2.Replace("value", param3) : String.Empty;

    //    String filter2 = param4 != null && !param4.Equals(String.Empty) ? " AND " + param4 : String.Empty;

    //    String sql = "SELECT COUNT(*) ";

    //    sql += "FROM veau ";
    //    sql += "WHERE VEAU_COD_FILIAL = " + param1 + filter1 + filter2;

    //    return int.Parse(DataAccessLayerManager.getInstance().getListBySelect(sql).Rows[0][0].ToString());
    //}

    //public NaturezaOperacaoBO getNaturezaOperacaoBO()
    //{
    //    NaturezaOperacaoBO naturezaOperacaoBO = null;

    //    if (VEAU_COD_NAT_OPER.HasValue)
    //    {
    //        naturezaOperacaoBO = NaturezaOperacaoBO.getInstance().find(VEAU_COD_FILIAL, VEAU_COD_NAT_OPER.Value);
    //    }

    //    if (naturezaOperacaoBO == null)
    //    {
    //        naturezaOperacaoBO = NaturezaOperacaoBO.getInstance();
    //    }

    //    return naturezaOperacaoBO;
    //}

    //public ParceirosBO getEmitenteBO()
    //{
    //    ParceirosBO parceirosBO = null;

    //    if (VEAU_INFNFE_EMIT_COD_PARC.HasValue)
    //    {
    //        parceirosBO = ParceirosBO.getInstance().find(VEAU_COD_FILIAL, VEAU_INFNFE_EMIT_COD_PARC.Value);
    //    }

    //    if (parceirosBO == null)
    //    {
    //        parceirosBO = ParceirosBO.getInstance();
    //    }

    //    return parceirosBO;
    //}

    //public ParceirosBO getDestinatarioBO()
    //{
    //    ParceirosBO parceirosBO = null;

    //    if (VEAU_INFNFE_DEST_COD_PARC.HasValue)
    //    {
    //        parceirosBO = ParceirosBO.getInstance().find(VEAU_COD_FILIAL, VEAU_INFNFE_DEST_COD_PARC.Value);
    //    }

    //    if (parceirosBO == null)
    //    {
    //        parceirosBO = ParceirosBO.getInstance();
    //    }

    //    return parceirosBO;
    //}

    //public NotaFiscalItemBO getNotaFiscalItemBO()
    //{
    //    NotaFiscalItemBO bo = null;

    //    //if (VEAU_INFNFE_DEST_COD_PARC.HasValue)
    //    //{
    //    bo = 
    //    //}

    //    if (bo == null)
    //    {
    //        bo = NotaFiscalItemBO.getInstance();
    //    }

    //    return bo;
    //}

    //public ParceirosBO getTransporteBO()
    //{
    //    ParceirosBO parceirosBO = null;

    //    if (VEAU_COD_NAT_OPER.HasValue)
    //    {
    //        parceirosBO = ParceirosBO.getInstance().find(VEAU_COD_FILIAL, VEAU_INFNFE_DEST_COD_PARC.Value);
    //    }

    //    if (parceirosBO == null)
    //    {
    //        parceirosBO = ParceirosBO.getInstance();
    //    }

    //    return parceirosBO;
    //}
}
