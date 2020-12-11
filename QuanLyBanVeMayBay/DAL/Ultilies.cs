using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Ultilies
    {
        static string SQL_CONNECTION = @"Data Source=DESKTOP-EHFOHPL\LEQUOCANH;Initial Catalog=QLBANVEMAYBAY;Integrated Security=True";



        public SqlConnection createConnection()
        {
            return new SqlConnection(SQL_CONNECTION);
        }



        public DataTable getDSSB()
        {
            SqlConnection sqlConnection = createConnection();
            string sql = "SELECT * FROM SAN_BAY";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            //SqlCommand cmd = new SqlCommand("SELECT *  FROM DOIBONG", sqlConnection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DGVHienThi.DataSource = ds.Tables[0];
            //DGVHienThi.Refresh();
            return ds.Tables[0];
        }



        public bool themSanBay(SanBay sB)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO SAN_BAY(MaSB,TenSB) VALUES ('" + txtMaSB.Text + "',N'" + txtTenSB.Text + "')", con);
                string SQL = "INSERT INTO SAN_BAY(MaSB, TenSB) VALUES ('" + sB.MaSB + "', N'" + sB.TenSB + "')";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        public bool suaSanBay(SanBay sB)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "UPDATE SAN_BAY SET TenSB = N'" + sB.TenSB + "' WHERE MaSB = '" + sB.MaSB + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        public bool xoaSanBay(SanBay sB)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "DELETE SAN_BAY WHERE MaSB = '" + sB.MaSB + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        public DataTable GetDataTimKiemSB(SanBay sB)
        {
            SqlConnection sqlConnection = createConnection();
            string sql = "SELECT MaSB, TenSB FROM SAN_BAY WHERE (MaSB = '" + sB.MaSB + "') OR (TenSB LIKE N'%" + sB.TenSB + "%')";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            //SqlCommand cmd = new SqlCommand("SELECT *  FROM DOIBONG", sqlConnection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DGVHienThi.DataSource = ds.Tables[0];
            //DGVHienThi.Refresh();
            return ds.Tables[0];
        }
        //                          LICH CHUYEN BAY                         //



        public DataTable getDSLCB()
        {
            SqlConnection sqlConnection = createConnection();
            string sql = "SELECT MaCB, S1.TenSB, S.TenSB, GiaTien, NgayGio, ThoiGianBay, SoLuongGheHang1, SoLuongGheHang2 FROM LICH_CHUYEN_BAY L, SAN_BAY S, SAN_BAY S1 WHERE L.MaSBDen = S.MaSB AND L.MaSBDi = S1.MaSB";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            //SqlCommand cmd = new SqlCommand("SELECT *  FROM DOIBONG", sqlConnection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DGVHienThi.DataSource = ds.Tables[0];
            //DGVHienThi.Refresh();
            return ds.Tables[0];
        }



        public bool themLichChuyenBay(LichChuyenBay lCB)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO SAN_BAY(MaSB,TenSB) VALUES ('" + txtMaSB.Text + "',N'" + txtTenSB.Text + "')", con);
                string SQL = "INSERT INTO LICH_CHUYEN_BAY(MaCB, MaSBDi, MaSBDen, GiaTien, NgayGio, ThoiGianBay, SoLuongGheHang1, SoLuongGheHang2) VALUES ('" + lCB.MaCB + "', '" + lCB.MaSBDi + "', '" + lCB.MaSBDen + "','" + lCB.GiaTien + "','" + lCB.NgayGio + "', '" + lCB.ThoiGianBay + "', '" + lCB.SoLuongGheHang1 + "', '" + lCB.SoLuongGheHang2 + "')";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        public bool suaLichChuyenBay(LichChuyenBay lCB)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "UPDATE LICH_CHUYEN_BAY SET MaSBDi = '" + lCB.MaSBDi + "', MaSBDen = '" + lCB.MaSBDen + "', GiaTien = '" + lCB.GiaTien + "', NgayGio = '" + lCB.NgayGio + "', ThoiGianBay = '" + lCB.ThoiGianBay + "', SoLuongGheHang1 = '" + lCB.SoLuongGheHang1 + "', SoLuongGheHang2 = '" + lCB.SoLuongGheHang2 + "' WHERE MaCB = '" + lCB.MaCB + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        public bool xoaLichChuyenBay(LichChuyenBay lCB)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "DELETE LICH_CHUYEN_BAY WHERE MaCB = '" + lCB.MaCB + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }



        public DataTable GetDataTimKiemCB(LichChuyenBay lCB)
        {
            SqlConnection sqlConnection = createConnection();
            string sql = "SELECT MaCB, S1.TenSB, S.TenSB, GiaTien, NgayGio, ThoiGianBay, SoLuongGheHang1, SoLuongGheHang2 FROM LICH_CHUYEN_BAY L, SAN_BAY S, SAN_BAY S1 WHERE (L.MaSBDen = S.MaSB AND L.MaSBDi = S1.MaSB) AND (MaCB = '" + lCB.MaCB + "') OR (MaSBDi = '" + lCB.MaSBDi + "' AND MaSBDen = '" + lCB.MaSBDen + "') OR (MaSBDi = '" + lCB.MaSBDi + "') OR (MaSBDen = '" + lCB.MaSBDen + "')";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            //SqlCommand cmd = new SqlCommand("SELECT *  FROM DOIBONG", sqlConnection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DGVHienThi.DataSource = ds.Tables[0];
            //DGVHienThi.Refresh();
            return ds.Tables[0];
        }




        //                          CHI TIET LICH CHUYEN BAY                         //




        public DataTable getDSChiTietCB()
        {
            SqlConnection sqlConnection = createConnection();
            string sql = "SELECT * FROM CHI_TIET_LICH_CHUYEN_BAY";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            //SqlCommand cmd = new SqlCommand("SELECT *  FROM DOIBONG", sqlConnection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DGVHienThi.DataSource = ds.Tables[0];
            //DGVHienThi.Refresh();
            return ds.Tables[0];
        }



        public bool themChiTietCB(ChiTietChuyenBay ctCB)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO SAN_BAY(MaSB,TenSB) VALUES ('" + txtMaSB.Text + "',N'" + txtTenSB.Text + "')", con);
                string SQL = "INSERT INTO CHI_TIET_LICH_CHUYEN_BAY(MaCT, MaCB, MaSBTrungGian, ThoiGianDung, GhiChu) VALUES ('" + ctCB.MaCT + "', '" + ctCB.MaCB + "', '" + ctCB.MaSBTrungGian + "','" + ctCB.ThoiGianDung + "','" + ctCB.GhiChu + "')";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        public bool suaChiTietCB(ChiTietChuyenBay ctCB)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "UPDATE CHI_TIET_LICH_CHUYEN_BAY SET MaCB = '" + ctCB.MaCB + "', MaSBTrungGian = '" + ctCB.MaSBTrungGian + "', ThoiGianDung = '" + ctCB.ThoiGianDung + "', GhiChu = '" + ctCB.GhiChu + "' WHERE MaCT = '" + ctCB.MaCT + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        public bool xoaChiTietCB(ChiTietChuyenBay ctCB)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "DELETE CHI_TIET_LICH_CHUYEN_BAY WHERE MaCT = '" + ctCB.MaCT + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        //                          VE CHUYEN BAY                         //




        public DataTable getBanVe()
        {
            SqlConnection sqlConnection = createConnection();
            string sql = "SELECT * FROM VE_CHUYEN_BAY";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            //SqlCommand cmd = new SqlCommand("SELECT *  FROM DOIBONG", sqlConnection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DGVHienThi.DataSource = ds.Tables[0];
            //DGVHienThi.Refresh();
            return ds.Tables[0];
        }



        public bool themBanVeCB(BanVe bV)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO SAN_BAY(MaSB,TenSB) VALUES ('" + txtMaSB.Text + "',N'" + txtTenSB.Text + "')", con);

                string SQL = "INSERT INTO VE_CHUYEN_BAY(MaVeCB, MaCB, MaHK, MaHV, GiaTien) VALUES ('" + bV.MaVeCB + "','" + bV.MaCB + "', '" + bV.MaHK + "', '" + bV.MaHV + "', '" + bV.GiaTien + "')";
                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }



        public bool suaBanVeCB(BanVe bV)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "UPDATE VE_CHUYEN_BAY SET MaCB = '" + bV.MaCB + "', MaHK = '" + bV.MaHK + "', MaHV = '" + bV.MaHV + "', GiaTien = '" + bV.GiaTien + "' WHERE MaVeCB = '" + bV.MaVeCB + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }



        public bool xoaBanVeCB(BanVe bV)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "DELETE VE_CHUYEN_BAY WHERE MaVeCB = '" + bV.MaVeCB + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }



        public DataTable GetDataTimKiemVeCB(BanVe bV)
        {
            SqlConnection sqlConnection = createConnection();
            string sql = "SELECT MaVeCB, MaCB, MaHK, MaHV, GiaTien FROM VE_CHUYEN_BAY WHERE (MaVeCB = '" + bV.MaVeCB + "') OR (MaHK = '" + bV.MaHK + "')";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            //SqlCommand cmd = new SqlCommand("SELECT *  FROM DOIBONG", sqlConnection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DGVHienThi.DataSource = ds.Tables[0];
            //DGVHienThi.Refresh();
            return ds.Tables[0];
        }




        //                          Hang Ve                         //




        public DataTable getHangVe()
        {
            SqlConnection sqlConnection = createConnection();
            string sql = "SELECT * FROM HANG_VE";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            //SqlCommand cmd = new SqlCommand("SELECT *  FROM DOIBONG", sqlConnection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DGVHienThi.DataSource = ds.Tables[0];
            //DGVHienThi.Refresh();
            return ds.Tables[0];
        }



        public bool themHangVe(HangVe hV)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO SAN_BAY(MaSB,TenSB) VALUES ('" + txtMaSB.Text + "',N'" + txtTenSB.Text + "')", con);
                string SQL = "INSERT INTO HANG_VE(MaHV, TenHV, GhiChu) VALUES ('" + hV.MaHV + "', N'" + hV.TenHV + "',N'" + hV.GhiChu + "')";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }



        public bool xoaHangVe(HangVe hV)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "DELETE HANG_VE WHERE MaHV = '" + hV.MaHV + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }



        public bool suaHangVe(HangVe hV)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "UPDATE HANG_VE SET TenHV = N'" + hV.TenHV + "', GhiChu = N'" + hV.GhiChu + "' WHERE MaHV = '" + hV.MaHV + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        //                          Hanh Khach                         //



        public DataTable getHanhKhach()
        {
            SqlConnection sqlConnection = createConnection();
            string sql = "SELECT * FROM HANH_KHACH";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            //SqlCommand cmd = new SqlCommand("SELECT *  FROM DOIBONG", sqlConnection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DGVHienThi.DataSource = ds.Tables[0];
            //DGVHienThi.Refresh();
            return ds.Tables[0];
        }



        public bool themHanhKhach(HanhKhach hK)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO SAN_BAY(MaSB,TenSB) VALUES ('" + txtMaSB.Text + "',N'" + txtTenSB.Text + "')", con);

                string SQL = "INSERT INTO HANH_KHACH(MaHK, TenHK, CMND, DienThoai) VALUES ('" + hK.MaHK + "','" + hK.TenHK + "', '" + hK.CMND + "', '" + hK.DienThoai + "')";
                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }



        public bool xoaHanhKhach(HanhKhach hK)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "DELETE HANH_KHACH WHERE MaHK = '" + hK.MaHK + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        public bool suaHanhKhach(HanhKhach hK)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "UPDATE HANH_KHACH SET TenHK = '" + hK.TenHK + "', CMND = '" + hK.CMND + "', DienThoai = '" + hK.DienThoai + "' WHERE MaHK = '" + hK.MaHK + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }



        public DataTable GetDataTimKiemHK(HanhKhach hK)
        {
            SqlConnection sqlConnection = createConnection();
            string sql = "SELECT MaHK, TenHK, CMND, DienThoai FROM HANH_KHACH WHERE (MaHK = '" + hK.MaHK + "') OR (TenHK LIKE '%" + hK.TenHK + "%') OR (CMND = '" + hK.CMND + "') OR (DienThoai ='" + hK.DienThoai + "')";
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            //SqlCommand cmd = new SqlCommand("SELECT *  FROM DOIBONG", sqlConnection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DGVHienThi.DataSource = ds.Tables[0];
            //DGVHienThi.Refresh();
            return ds.Tables[0];
        }



        //                                      Bao Cao Thang                                       //



        public DataTable getBaoCaoThang()
        {
            SqlConnection sqlConnection = createConnection();
            string sql = "SELECT * FROM BAO_CAO_DOANH_THU_THANG";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            //SqlCommand cmd = new SqlCommand("SELECT *  FROM DOIBONG", sqlConnection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DGVHienThi.DataSource = ds.Tables[0];
            //DGVHienThi.Refresh();
            return ds.Tables[0];
        }



        public bool themBaoCaoThang(BaoCaoThang bCT)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO SAN_BAY(MaSB,TenSB) VALUES ('" + txtMaSB.Text + "',N'" + txtTenSB.Text + "')", con);

                string SQL = "INSERT INTO BAO_CAO_DOANH_THU_THANG(MaBaoCaoThang, Thang)  VALUES ('" + bCT.MaBCThang + "', '" + bCT.Thang + "')";
                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);
                string SQL1 = "UPDATE BAO_CAO_DOANH_THU_THANG SET TongDoanhThu = (SELECT SUM(V.GiaTien) FROM VE_CHUYEN_BAY V, LICH_CHUYEN_BAY L WHERE V.MaCB = L.MaCB AND MONTH(L.NgayGio) = " + bCT.Thang + " AND YEAR(L.NgayGio) = (SELECT SUBSTRING('" + bCT.MaBCThang + "',6,4))) WHERE MaBaoCaoThang = '" + bCT.MaBCThang + "'";
                SqlCommand cmd1 = new SqlCommand(SQL1, sqlConnection);
                // Query và kiểm tra
                if ((cmd.ExecuteNonQuery() > 0) && (cmd1.ExecuteNonQuery() > 0))
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }



        public bool xoaBCThang(BaoCaoThang bCT)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "DELETE BAO_CAO_DOANH_THU_THANG WHERE MaBaoCaoThang = '" + bCT.MaBCThang + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        public bool suaBCThang(BaoCaoThang bCT)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "UPDATE BAO_CAO_DOANH_THU_THANG SET Thang = '" + bCT.Thang + "', TongDoanhThu = '" + bCT.TongDoanhThu + "' WHERE MaBaoCaoThang = '" + bCT.MaBCThang + "'"; ;

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        //                              CHI TIET BAO CAO THANG                              //



        public DataTable getChiTietBaoCaoThang()
        {
            SqlConnection sqlConnection = createConnection();
            string sql = "SELECT * FROM CHI_TIET_BAO_CAO_DOANH_THU_THANG";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            //SqlCommand cmd = new SqlCommand("SELECT *  FROM DOIBONG", sqlConnection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DGVHienThi.DataSource = ds.Tables[0];
            //DGVHienThi.Refresh();
            return ds.Tables[0];
        }




        public bool themCTBaoCaoThang(ChiTietBaoCaoThang ctBCT)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO SAN_BAY(MaSB,TenSB) VALUES ('" + txtMaSB.Text + "',N'" + txtTenSB.Text + "')", con);

                string SQL = "INSERT INTO CHI_TIET_BAO_CAO_DOANH_THU_THANG(MaCB, MaBaoCaoThang) VALUES ('" + ctBCT.MaCB + "', '" + ctBCT.MaBCThang + "')";
                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);
                string SQL1 = "UPDATE CHI_TIET_BAO_CAO_DOANH_THU_THANG SET SoVe = (SELECT COUNT(MaVeCB) FROM VE_CHUYEN_BAY V, LICH_CHUYEN_BAY L WHERE V.MaCB = L.MaCB AND MONTH(L.NgayGio) = (SELECT SUBSTRING('" + ctBCT.MaBCThang + "',4,2)) AND YEAR(L.NgayGio) = (SELECT SUBSTRING('" + ctBCT.MaBCThang + "',6,4))), DoanhThu = (SELECT SUM(V.GiaTien) FROM VE_CHUYEN_BAY V, LICH_CHUYEN_BAY L WHERE V.MaCB = L.MaCB AND MONTH(L.NgayGio) = (SELECT SUBSTRING('" + ctBCT.MaBCThang + "',4,2)) AND YEAR(L.NgayGio) = (SELECT SUBSTRING('" + ctBCT.MaBCThang + "',6,4))) WHERE MaBaoCaoThang = '" + ctBCT.MaBCThang + "'";
                SqlCommand cmd1 = new SqlCommand(SQL1, sqlConnection);
                // Query và kiểm tra
                if ((cmd.ExecuteNonQuery() > 0) && (cmd1.ExecuteNonQuery() > 0))
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }



        public bool xoaCTBaoCaoThang(ChiTietBaoCaoThang ctBCT)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "DELETE CHI_TIET_BAO_CAO_DOANH_THU_THANG WHERE STT = '" + ctBCT.STT + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        public bool suaCTBaoCaoThang(ChiTietBaoCaoThang ctBCT)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "UPDATE CHI_TIET_BAO_CAO_DOANH_THU_THANG SET MaCB = '" + ctBCT.MaCB + "', SoVe = '" + ctBCT.SoVe + "', DoanhThu = '" + ctBCT.DoanhThu + "', MaBaoCaoThang = '" + ctBCT.MaBCThang + "' WHERE STT = '" + ctBCT.STT + "'"; ;

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        //                                      BAO CAO NAM                                   //



        public DataTable getBaoCaoNam()
        {
            SqlConnection sqlConnection = createConnection();
            string sql = "SELECT * FROM BAO_CAO_DOANH_THU_NAM";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            //SqlCommand cmd = new SqlCommand("SELECT *  FROM DOIBONG", sqlConnection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DGVHienThi.DataSource = ds.Tables[0];
            //DGVHienThi.Refresh();
            return ds.Tables[0];
        }



        public bool themBaoCaoNam(BaoCaoNam bCN)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO SAN_BAY(MaSB,TenSB) VALUES ('" + txtMaSB.Text + "',N'" + txtTenSB.Text + "')", con);

                string SQL = "INSERT INTO BAO_CAO_DOANH_THU_NAM (MaBaoCaoNam) VALUES ('" + bCN.MaBCNam + "')";
                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);
                string SQL1 = "UPDATE BAO_CAO_DOANH_THU_NAM SET Nam = (SELECT SUBSTRING('" + bCN.MaBCNam + "',4,4)), TongDoanhThuNam = (SELECT SUM(V.GiaTien) FROM VE_CHUYEN_BAY V, LICH_CHUYEN_BAY L WHERE V.MaCB = L.MaCB AND YEAR(L.NgayGio) = (SELECT SUBSTRING('"+ bCN.MaBCNam +"',4,4))) WHERE MaBaoCaoNam = '" + bCN.MaBCNam + "'";
                SqlCommand cmd1 = new SqlCommand(SQL1, sqlConnection);
                // Query và kiểm tra
                if ((cmd.ExecuteNonQuery() > 0) && (cmd1.ExecuteNonQuery() > 0))
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }



        public bool xoaBCNam(BaoCaoNam bCN)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "DELETE BAO_CAO_DOANH_THU_NAM WHERE MaBaoCaoNam = '" + bCN.MaBCNam + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        public bool suaBCNam(BaoCaoNam bCN)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "UPDATE BAO_CAO_DOANH_THU_NAM SET Nam = '" + bCN.Nam + "', TongDoanhThuNam = '" + bCN.TongDoanhThuNam + "' WHERE MaBaoCaoNam = '" + bCN.MaBCNam + "'"; ;

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        //                                      CHI TIET BAO CAO NAM                                   //



        public DataTable getCTBaoCaoNam()
        {
            SqlConnection sqlConnection = createConnection();
            string sql = "SELECT * FROM CHI_TIET_BAO_CAO_DOANH_THU_NAM";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            //SqlCommand cmd = new SqlCommand("SELECT *  FROM DOIBONG", sqlConnection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DGVHienThi.DataSource = ds.Tables[0];
            //DGVHienThi.Refresh();
            return ds.Tables[0];
        }



        public bool themCTBaoCaoNam(ChiTietBaoCaoNam ctBCN)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO SAN_BAY(MaSB,TenSB) VALUES ('" + txtMaSB.Text + "',N'" + txtTenSB.Text + "')", con);

                string SQL = "INSERT INTO CHI_TIET_BAO_CAO_DOANH_THU_NAM(MaCTBCNam, Thang, MaBaoCaoNam) VALUES ('"+ ctBCN.MaCTBCNam +"','" + ctBCN.Thang +"', '"+ ctBCN.MaBCNam +"')";
                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);
                string SQL1 = "UPDATE CHI_TIET_BAO_CAO_DOANH_THU_NAM SET SoChuyenBay = (SELECT COUNT(DISTINCT V.MaCB) FROM VE_CHUYEN_BAY V, LICH_CHUYEN_BAY L WHERE V.MaCB = L.MaCB AND MONTH(L.NgayGio) = '"+ ctBCN.Thang +"' AND YEAR(L.NgayGio) = (SELECT SUBSTRING('"+ ctBCN.MaBCNam +"',4,4))), DoanhThu = (SELECT SUM(V.GiaTien) FROM VE_CHUYEN_BAY V, LICH_CHUYEN_BAY L WHERE V.MaCB = L.MaCB AND MONTH(L.NgayGio) = '"+ ctBCN.Thang +"' AND YEAR(L.NgayGio) = (SELECT SUBSTRING('"+ ctBCN.MaBCNam + "',4,4))) WHERE MaCTBCNam = '" + ctBCN.MaCTBCNam + "'";
                SqlCommand cmd1 = new SqlCommand(SQL1, sqlConnection);
                // Query và kiểm tra
                if ((cmd.ExecuteNonQuery() > 0) && (cmd1.ExecuteNonQuery() > 0))
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }



        public bool xoaCTBaoCaoNam(ChiTietBaoCaoNam ctBCN)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "DELETE CHI_TIET_BAO_CAO_DOANH_THU_NAM WHERE MaCTBCNam = '" + ctBCN.MaCTBCNam + "'";

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }




        public bool suaCTBaoCaoNam(ChiTietBaoCaoNam ctBCN)
        {
            SqlConnection sqlConnection = createConnection();
            try
            {
                sqlConnection.Open();
                string SQL = "UPDATE CHI_TIET_BAO_CAO_DOANH_THU_NAM SET Thang = '" + ctBCN.Thang + "', SoChuyenBay = '" + ctBCN.SoChuyenBay + "', DoanhThu = '" + ctBCN.DoanhThu + "', MaBaoCaoNam = '" + ctBCN.MaBCNam + "' WHERE MaCTBCNam = '" + ctBCN.MaCTBCNam + "'"; ;

                SqlCommand cmd = new SqlCommand(SQL, sqlConnection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                sqlConnection.Close();
            }
            return false;
        }
    }
}
