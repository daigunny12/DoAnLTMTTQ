
package Service;
import DAO.BanHangDAO;
import DAO.BanHangDAOImpl;
import Object.CTHDBanHangObj;
import Object.HoaDonBanHangObj;

public class BanHangServiceImpl implements BanHangService{

    private BanHangDAO banHangDAO= null;

    public BanHangServiceImpl() {
        this.banHangDAO = new BanHangDAOImpl();
    }
    
    
    @Override
    public int setMaHD() {
        return banHangDAO.setMaHD();
    }

    @Override
    public boolean upDateCTHDBan(CTHDBanHangObj cTHDBanHangObj) {
        return banHangDAO.upDateCTHDBan(cTHDBanHangObj);
    }

    @Override
    public boolean upDateHoaDonBan(HoaDonBanHangObj hoaDonBanHangObj) {
        return banHangDAO.upDateHoaDonBan(hoaDonBanHangObj);
    }

    @Override
    public boolean upTienNo(HoaDonBanHangObj hoaDonBanHangObj) {
        return banHangDAO.upTienNo(hoaDonBanHangObj);
    }
    
}
