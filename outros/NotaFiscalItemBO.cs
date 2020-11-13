using com.sotisolutions.khronus.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using com.sotisolutions.khronus.dal.dbo;
using com.sotisolutions.khronus.dal;

/// <summary>
/// Summary description for NotaFiscalBO
/// </summary>
[TableAttr("veav")]
public class NotaFiscalItemBO: BusinessObjectBase
{
    public const String NOTA_FISCAL_ITEM_IMPOSTO_IPI_TIPO_POR_ALIQ = "0";
    public const String NOTA_FISCAL_ITEM_IMPOSTO_IPI_TIPO_POR_QTD = "1";

    public const String NOTA_FISCAL_ITEM_IMPOSTO_PIS_TIPO_POR_ALIQ = "0";
    public const String NOTA_FISCAL_ITEM_IMPOSTO_PIS_TIPO_POR_QTD = "1";

    public const String NOTA_FISCAL_ITEM_IMPOSTO_COFINS_TIPO_POR_ALIQ = "0";
    public const String NOTA_FISCAL_ITEM_IMPOSTO_COFINS_TIPO_POR_QTD = "1";


    [@FieldAttr]
    [KeyAttr]
    public int VEAV_COD_FILIAL { get; set; }

    [@FieldAttr]
    [KeyAttr]
    public int VEAV_COD_NOTA { get; set; }


    [@FieldAttr]
    [KeyAttr]
    public int VEAV_ITEM { get; set; }

    [@FieldAttr]
    public String VEAV_DET_PROD_APLICACAO { get; set; }

    [@FieldAttr]
    public String VEAV_DET_PROD_CPROD { get; set; }

    [@FieldAttr]
    public String VEAV_DET_PROD_CEAN { get; set; }

    [@FieldAttr]
    public String VEAV_DET_PROD_XPROD { get; set; }

    [@FieldAttr]
    public String VEAV_DET_PROD_INFOPROD { get; set; }


    [@FieldAttr]
    [IsForeignKey]
    [IsNull]
    public String VEAV_DET_PROD_NCM { get; set; }


    [@FieldAttr]
    public String VEAV_DET_PROD_EXTIPI { get; set; }

    [@FieldAttr]
    public String VEAV_DET_PROD_CEST { get; set; }


    [@FieldAttr]
    [IsForeignKey]
    [IsNull]
    public String VEAV_DET_PROD_CFOP { get; set; }


    [@FieldAttr]
    public String VEAV_DET_PROD_UCOM { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_PROD_QCOM { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_PROD_VUNCOM { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_PROD_VPROD { get; set; }

    [@FieldAttr]
    public String VEAV_DET_PROD_CEANTRIB { get; set; }

    [@FieldAttr]
    public String VEAV_DET_PROD_UTRIB { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_PROD_QTRIB { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_PROD_VUNTRIB { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_PROD_VFRETE { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_PROD_VSEG { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_PROD_VDESC { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_PROD_VOUTRO { get; set; }

    [@FieldAttr]
    public String VEAV_DET_PROD_INDTOT { get; set; }


    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_ICMS_ORIG { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_ICMS_CST_CSOSN { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_ICMS_MODBC { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_PREDBC { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_VBC { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_PICMS { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_VICMS { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_ICMS_VBC_FORMULA { get; set; }


    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_ICMS_MODBCST { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_PMVAST { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_PREDBCST { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_VBCST { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_PICMSST { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_VICMSST { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_ICMS_MOTDESICMS { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_VBCSTRET { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_VICMSSTRET { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_PCREDSN { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_VCREDICMSSN { get; set; }


    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_VBCUFDEST { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_PFCPUFDEST { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_PICMSUFDEST { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_PICMSINTER { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_PICMSINTERPART { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_VFCPUFDEST { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_VICMSUFDEST { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_ICMS_VICMSUFREMET { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_ICMS_VBCUFDEST_FORMULA { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_IPI_TIPO { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_IPI_CLENQ { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_IPI_CNPJPROD { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_IPI_CSELO { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_IPI_QSELO { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_IPI_CENQ { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_IPI_CST { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_IPI_VBC_QUNID { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_IPI_PIPI_VUNID { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_IPI_VIPI { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_PIS_TIPO { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_PIS_CST { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_PIS_VBC_QBCPROD { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_PIS_PPIS_VALIQPROD { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_PIS_VPIS { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_PIS_VBC_QBCPROD_FORMULA { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_COFINS_TIPO { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_COFINS_CST { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_COFINS_VBC_QBCPROD { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_COFINS_PCOFINS_VALIQPROD { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_COFINS_VCOFINS { get; set; }

    [@FieldAttr]
    public String VEAV_DET_IMPOSTO_COFINS_VBC_QBCPROD_FORMULA { get; set; }


    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_II_VBC { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_II_VDESPADU { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_II_VII { get; set; }

    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_II_VIOF { get; set; }


    [@FieldAttr]
    public decimal VEAV_DET_IMPOSTO_VL_TOT_TRIB { get; set; }


    //[@FieldAttr]
    //public String VEAV_USU_ULT_ALT { get; set; }

    //[@FieldAttr]
    //public DateTime VEAV_DAT_ULT_ALT { get; set; }


    //[@FieldAttr]
    //public String VEAV_STATUS { get; set; }

    //private List<NotaFiscalItemDecImportBO> notaFiscalItemDecImportBOList = new List<NotaFiscalItemDecImportBO>();
    //public List<NotaFiscalItemDecImportBO> getNotaFiscalItemDecImportBOList()
    //{
    //    return notaFiscalItemDecImportBOList;
    //}

    //public NotaFiscalItemBO()
    //{
    //    //
    //    // TODO: Add constructor logic here
    //    //
    //}

    //public static NotaFiscalItemBO getInstance()
    //{
    //    return new NotaFiscalItemBO();
    //}

    //public bool insert()
    //{
    //    return insert(this);
    //}

    //public bool insert(NotaFiscalItemBO bo)
    //{
    //    //bo.VEAV_CODIGO = GatUtilities.getNumerator(bo.VEAV_COD_FILIAL, this.GetType().Name);
    //    //bo.VEAV_USU_ULT_ALT = StringUtilities.toString(HttpContext.Current.Session["USUARIO"]);
    //    //bo.VEAV_DAT_ULT_ALT = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

    //    bool ret = DataAccessLayerManager.getInstance().insert(bo);

    //    if (ret)
    //    {
    //        foreach (NotaFiscalItemDecImportBO notaFiscalItemDecImportBO in notaFiscalItemDecImportBOList)
    //        {
    //            notaFiscalItemDecImportBO.VEAY_COD_NOTA = bo.VEAV_COD_NOTA;
    //            ret = notaFiscalItemDecImportBO.insert();

    //            if (!ret)
    //            {
    //                break;
    //            }
    //        }
    //    }

    //    return ret;
    //}

    //public bool update()
    //{
    //    return update(this);
    //}

    //public bool update(NotaFiscalItemBO bo)
    //{
    //    //bo.VEAV_USU_ULT_ALT = StringUtilities.toString(HttpContext.Current.Session["USUARIO"]);
    //    //bo.VEAV_DAT_ULT_ALT = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

    //    bool ret = DataAccessLayerManager.getInstance().update(bo);

    //    if (ret)
    //    {
    //        DataTable dataTable = NotaFiscalItemDecImportBO.getInstance().getList(VEAV_COD_FILIAL, VEAV_COD_NOTA, VEAV_ITEM);
    //        foreach (DataRow row in dataTable.Rows)
    //        {
    //            NotaFiscalItemDecImportBO notaFiscalItemDecImportBO1 = NotaFiscalItemDecImportBO.getInstance().find(
    //                NumberUtilities.parseInt(row["VEAY_COD_FILIAL"]),
    //                NumberUtilities.parseInt(row["VEAY_COD_NOTA"]),
    //                NumberUtilities.parseInt(row["VEAY_ITEM_NOTA"]),
    //                StringUtilities.toString(row["VEAY_NDI"]));

    //            bool match = false;

    //            while (notaFiscalItemDecImportBOList.Count > 0)
    //            {
    //                NotaFiscalItemDecImportBO notaFiscalItemDecImportBO2 = notaFiscalItemDecImportBOList[0];

    //                if (notaFiscalItemDecImportBO1.VEAY_NDI == notaFiscalItemDecImportBO2.VEAY_NDI)
    //                {
    //                    match = true;

    //                    ret = notaFiscalItemDecImportBO2.update();

    //                    if (!ret)
    //                    {
    //                        break;
    //                    }

    //                    notaFiscalItemDecImportBOList.Remove(notaFiscalItemDecImportBO2);
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
    //                    notaFiscalItemDecImportBO1.delete();
    //                }
    //            }
    //        }
    //    }

    //    if (ret)
    //    {
    //        foreach (NotaFiscalItemDecImportBO notaFiscalItemDecImportBO in notaFiscalItemDecImportBOList)
    //        {
    //            notaFiscalItemDecImportBO.VEAY_COD_NOTA = bo.VEAV_COD_NOTA;
                
    //            ret = notaFiscalItemDecImportBO.insert();

    //            if (!ret)
    //            {
    //                break;
    //            }
    //        }
    //    }

    //    return ret;
    //}

    //public bool delete()
    //{
    //    return delete(this);
    //}

    //public bool delete(NotaFiscalItemBO bo)
    //{
    //    return DataAccessLayerManager.getInstance().delete(bo);
    //}

    //public NotaFiscalItemBO find(int param1, int param2, int param3)
    //{
    //    return (NotaFiscalItemBO)DataAccessLayerManager.getInstance().find(this, new Object[,] { { "VEAV_COD_FILIAL", param1 }, { "VEAV_COD_NOTA", param2 }, { "VEAV_ITEM", param3 } });
    //}

    //public DataTable getList(int param1, int param2)
    //{
    //    return DataAccessLayerManager.getInstance().getList(this, new Object[,] { { "VEAV_COD_FILIAL", param1 }, { "VEAV_COD_NOTA", param2 } });
    //}

    //public DataTable getList(int param1, String param2, String param3, int pageNumber, int pageSize)
    //{
    //    //String filter = param3 != null  ? " AND " + param2.Replace("value", param3) : String.Empty;

    //    //String sql = "SELECT * FROM (";

    //    //sql += "SELECT ROW_NUMBER() OVER(ORDER BY VEAV_COD_FILIAL) AS NUMBER, VEAV_COD_FILIAL, VEAV_COD_NOTA, VEAV_ITEM, VEAV_DET_NITEM, VEAV_DET_PROD_CPROD, VEAV_DET_PROD_CEAN, VEAV_DET_PROD_XPROD, VEAV_DET_PROD_NCM, VEAV_DET_PROD_EXTIPI, VEAV_DET_PROD_CFOP, VEAV_DET_PROD_UCOM, VEAV_DET_PROD_QCOM, VEAV_DET_PROD_VUNCOM, VEAV_DET_PROD_VPROD, VEAV_DET_PROD_CEANTRIB, VEAV_DET_PROD_UTRIB, VEAV_DET_PROD_QTRIB, VEAV_DET_PROD_VUNTRIB, VEAV_DET_PROD_VFRETE, VEAV_DET_PROD_VSEG, VEAV_DET_PROD_VDESC, VEAV_DET_PROD_VOUTRO, VEAV_DET_PROD_INDTOT, VEAV_DET_IMPOSTO_ICMS_ORIG, VEAV_DET_IMPOSTO_ICMS_CST_CSOSN, VEAV_DET_IMPOSTO_ICMS_MODBC, VEAV_DET_IMPOSTO_ICMS_PREDBC, VEAV_DET_IMPOSTO_ICMS_VBC, VEAV_DET_IMPOSTO_ICMS_PICMS, VEAV_DET_IMPOSTO_ICMS_VICMS, VEAV_DET_IMPOSTO_ICMS_MODBCST, VEAV_DET_IMPOSTO_ICMS_PMVAST, VEAV_DET_IMPOSTO_ICMS_PREDBCST, VEAV_DET_IMPOSTO_ICMS_VBCST, VEAV_DET_IMPOSTO_ICMS_PICMSST, VEAV_DET_IMPOSTO_ICMS_VICMSST, VEAV_DET_IMPOSTO_ICMS_MOTDESICMS, VEAV_DET_IMPOSTO_ICMS_VBCSTRET, VEAV_DET_IMPOSTO_ICMS_VICMSSTRET, VEAV_DET_IMPOSTO_ICMS_PCREDSN, VEAV_DET_IMPOSTO_ICMS_VCREDICMSSN, VEAV_DET_IMPOSTO_IPI_TIPO, VEAV_DET_IMPOSTO_IPI_CLENQ, VEAV_DET_IMPOSTO_IPI_CNPJPROD, VEAV_DET_IMPOSTO_IPI_CSELO, VEAV_DET_IMPOSTO_IPI_QSELO, VEAV_DET_IMPOSTO_IPI_CENQ, VEAV_DET_IMPOSTO_IPI_CST, VEAV_DET_IMPOSTO_IPI_VBC, VEAV_DET_IMPOSTO_IPI_PIPI, VEAV_DET_IMPOSTO_IPI_QUNID, VEAV_DET_IMPOSTO_IPI_VUNID, VEAV_DET_IMPOSTO_IPI_VIPI, VEAV_DET_IMPOSTO_PIS_TIPO, VEAV_DET_IMPOSTO_PIS_CST, VEAV_DET_IMPOSTO_PIS_VBC, VEAV_DET_IMPOSTO_PIS_PPIS, VEAV_DET_IMPOSTO_PIS_QBCPROD, VEAV_DET_IMPOSTO_PIS_VALIQPROD, VEAV_DET_IMPOSTO_PIS_VPIS, VEAV_DET_IMPOSTO_COFINS_TIPO, VEAV_DET_IMPOSTO_COFINS_CST, VEAV_DET_IMPOSTO_COFINS_VBC, VEAV_DET_IMPOSTO_COFINS_PCOFINS, VEAV_DET_IMPOSTO_COFINS_QBCPROD, VEAV_DET_IMPOSTO_COFINS_VALIQPROD, VEAV_DET_IMPOSTO_COFINS_VCOFINS, VEAV_STATUS ";
    //    //sql += "FROM VEAV ";
    //    //sql += "WHERE VEAV_COD_FILIAL = " + param1 + filter;
    //    //sql += ") AS VEAV ";

    //    //if (pageSize != 0) { sql += "WHERE NUMBER BETWEEN " + (pageNumber != 0 ? pageNumber + 1 : pageNumber) + " AND " + ((pageNumber != 0 ? pageNumber + 1 : pageNumber) + pageSize) + " "; }

    //    //return DataAccessLayerManager.getInstance().getListBySelect(sql);

    //    return DataAccessLayerManager.getInstance().getList(this, new Object[,] { { "VEAV_COD_FILIAL", param1 }, { "VEAV_COD_NOTA", param2 } });
    //}

    ////public int getListCount(int param1, String param2, String param3)
    ////{
    ////    String filter = param3 != null  ? " AND " + param2.Replace("value", param3) : String.Empty;

    ////    String sql = "SELECT COUNT(*) ";

    ////    sql += "FROM VEAV ";
    ////    sql += "WHERE VEAV_COD_FILIAL = " + param1 + filter;

    ////    return int.Parse(DataAccessLayerManager.getInstance().getListBySelect(sql).Rows[0][0].ToString());
    ////}
}
