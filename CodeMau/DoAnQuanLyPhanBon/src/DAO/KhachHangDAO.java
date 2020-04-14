
package DAO;

import java.util.List;
import Object.KhachHangObj;

public interface KhachHangDAO {
    public List<KhachHangObj> getList();
    
    public boolean UpdateTable(KhachHangObj khachHangObj);
    
    public boolean AddTable(KhachHangObj khachHangObj);
    
    public boolean Delete(int Ma);
    
}
