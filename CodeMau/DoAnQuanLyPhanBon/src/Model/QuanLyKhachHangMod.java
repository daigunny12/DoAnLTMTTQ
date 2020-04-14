
package Model;
import java.util.List;
import javax.swing.table.DefaultTableModel;
import Object.KhachHangObj;
public class QuanLyKhachHangMod {
   public DefaultTableModel setTableKhachHang(List<KhachHangObj> listItem , String[] listColumn){
       DefaultTableModel dtm = new DefaultTableModel(){
           @Override
           public boolean isCellEditable(int row, int column) {
               return false;
           }
           
       };
       dtm.setColumnIdentifiers(listColumn);
       int row = listItem.size();
       int columns = listColumn.length;
       Object[] obj = null;
       
       if(row >0){
           for(int i =0 ; i < row ; i++){
               KhachHangObj kh =listItem.get(i);
               obj = new Object[columns];
               
               obj[0] = i+1;
               obj[1] = kh.getMaKH();
               obj[2] = kh.getTenKH();
               obj[3] = kh.getDiaChi();
               obj[4] = kh.getSdt();
               int sn = (int)kh.getSoNo();
               obj[5] = sn ;
               obj[6] = kh.getGhiChu();
               
               dtm.addRow(obj);
           }
       }
              
      return dtm;
   }
}
