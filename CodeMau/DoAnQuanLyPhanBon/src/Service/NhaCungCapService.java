
package Service;

import java.util.List;
import Object.NhaCungCapObj;

public interface NhaCungCapService {
    public List<NhaCungCapObj> getList();
    
    public boolean UpdateTable(NhaCungCapObj nhaCungCapObj);
   
   public boolean AddTable(NhaCungCapObj nhaCungCapObj);
   
   public boolean Delete(int Ma);
}
