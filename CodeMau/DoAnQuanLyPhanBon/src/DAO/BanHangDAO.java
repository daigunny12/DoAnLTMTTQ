
package DAO;
import Object.CTHDBanHangObj;
import Object.HoaDonBanHangObj;
public interface BanHangDAO {
    public int setMaHD();
    public boolean upDateCTHDBan(CTHDBanHangObj cTHDBanHangObj);
    public boolean upDateHoaDonBan(HoaDonBanHangObj hoaDonBanHangObj);
    public boolean upTienNo(HoaDonBanHangObj hoaDonBanHangObj);
}
