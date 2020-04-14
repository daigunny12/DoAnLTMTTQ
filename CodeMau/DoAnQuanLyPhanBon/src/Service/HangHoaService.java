package Service;

import java.util.List;
import Object.HangHoaObj;

public interface HangHoaService {

    public List<HangHoaObj> getList();

    public boolean UpdateTable(HangHoaObj hangHoaObj);

    public boolean AddTable(HangHoaObj hangHoaObj);

    public boolean checkSL(int MaHH, int SL);

    public boolean upDateSLBanHang(int MaHH, int SL);

    public boolean upDateSLNhapHang(int MaHH, int SL);
    
    public boolean Delete(int Ma);
}
