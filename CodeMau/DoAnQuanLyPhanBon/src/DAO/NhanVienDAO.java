
package DAO;
import java.util.List;
import Object.NhanVienObj;

public interface NhanVienDAO {
    public List<NhanVienObj> getList();
    public boolean UpdateTable(NhanVienObj nhanVienObj);
    public boolean AddTable(NhanVienObj nhanVienObj);
    public boolean DeleteNV(int Ma);
}
