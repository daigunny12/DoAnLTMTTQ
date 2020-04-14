
package Model;
import javax.swing.table.AbstractTableModel;
import java.util.List;
import Object.HangHoaObj;

public class NhapHangModCtrl extends AbstractTableModel{
    private List<HangHoaObj> listItem;
    private final Class[] mClasses = {Integer.class, Integer.class, String.class,
        String.class, Integer.class, Float.class,
        Float.class, Float.class, Float.class};
    private final  String[] listColumn = {"STT","Mã SP", "Tên SP", "ĐVT", "SL", "Đơn giá", 
        "CK", "Tiền CK", "Thành Tiền"};

    public NhapHangModCtrl(List<HangHoaObj> listItem) {
        this.listItem = listItem;
    }
    
    @Override
    public void setValueAt(Object aValue, int rowIndex, int columnIndex) {
      HangHoaObj hh = listItem.get(rowIndex);
        switch(columnIndex){
            case 0:
                break;
            case 1:
                hh.setMaHH((int)aValue);
                break;
            case 2:
                 hh.setTeHH((String)aValue);
                 break;
            case 3:
                 hh.getDonViTinh();
                 break;
            case 4:
                 hh.setSl((int)aValue);
                 break;
            case 5:
                hh.setGiaBan((float)aValue);
                break;
            case 6:
                hh.setGiaMua((float)aValue);
                break;
            default:
                break;
     }
    }

    @Override
    public boolean isCellEditable(int rowIndex, int columnIndex) {
        if(columnIndex == 1 || columnIndex == 0 || columnIndex == 2 || columnIndex == 3 || columnIndex == 7 || columnIndex == 8){
            return false;
        }
        return true;
    }

    @Override
    public Class<?> getColumnClass(int columnIndex) {
        return mClasses[columnIndex];
    }

    @Override
    public String getColumnName(int column) {
        return listColumn[column];
    }

    @Override
    public int getRowCount() {
       return listItem.size();
    }

    @Override
    public int getColumnCount() {
        return listColumn.length;
    }

    @Override
    public Object getValueAt(int rowIndex, int columnIndex) {
          HangHoaObj hh = listItem.get(rowIndex);
        switch(columnIndex){
            case 0:
                return rowIndex +1;
            case 1:
                return hh.getMaHH();
            case 2:
                return hh.getTeHH();
            case 3:
                return hh.getDonViTinh();
            case 4:
                return hh.getSl();
            case 5:
                return hh.getGiaBan();
            case 6:
                return hh.getGiaMua();
            case 7:
                return hh.getSl() * hh.getGiaBan() * hh.getGiaMua() * 0.01;
            case 8:
                return (hh.getSl() * hh.getGiaBan()) -(hh.getSl() * hh.getGiaBan() * hh.getGiaMua() *0.01);
            default:
                return null;
     }
    } 
}
