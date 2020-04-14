
package Service;

import Object.CTHDBanHangObj;
import Object.HoaDonBanHangObj;


public interface BanHangService {
    public int setMaHD();
    public boolean upDateCTHDBan(CTHDBanHangObj cTHDBanHangObj);
    public boolean upDateHoaDonBan(HoaDonBanHangObj hoaDonBanHangObj);
    public boolean upTienNo(HoaDonBanHangObj hoaDonBanHangObj);
}
