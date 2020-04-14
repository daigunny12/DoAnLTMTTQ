
package Object;

import javax.swing.JLabel;
import javax.swing.JPanel;


public class DanhMucObj {
 private String kind;
 private JPanel pn;
 private JLabel lbl;

    public DanhMucObj() {
    }

    public DanhMucObj(String kind, JPanel pn, JLabel lbl) {
        this.kind = kind;
        this.pn = pn;
        this.lbl = lbl;
    }

    public String getKind() {
        return kind;
    }

    public void setKind(String kind) {
        this.kind = kind;
    }

    public JPanel getPn() {
        return pn;
    }

    public void setPn(JPanel pn) {
        this.pn = pn;
    }

    public JLabel getLbl() {
        return lbl;
    }

    public void setLbl(JLabel lbl) {
        this.lbl = lbl;
    }
    
 
}
