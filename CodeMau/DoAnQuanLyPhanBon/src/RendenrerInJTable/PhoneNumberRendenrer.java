/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package RendenrerInJTable;

import java.awt.BorderLayout;
import java.awt.Color;
import javax.swing.table.DefaultTableCellRenderer;
import java.awt.Component;
import java.awt.Font;
import javax.swing.JTable;
import javax.swing.SwingConstants;
import javax.swing.JPanel;
import javax.swing.JLabel;

public class PhoneNumberRendenrer extends DefaultTableCellRenderer {

    public static int currentRow = -1;

    @Override
    public Component getTableCellRendererComponent(JTable table, Object value, boolean isSelected, boolean hasFocus, int row, int column) {
        JPanel pn = new JPanel(new BorderLayout());
        JLabel lb = new JLabel();
        pn.add(lb, BorderLayout.CENTER);

        String phoneNumber = value.toString();
        String design = phoneNumber.substring(0, 3)+" " + phoneNumber.substring(3, 6) +" " + phoneNumber.substring(6, 10);
        value = design;
        
        lb.setHorizontalAlignment(SwingConstants.CENTER);
        lb.setText(value.toString());
        lb.setFont(new Font("Arial", Font.PLAIN, 16));
        lb.setForeground(Color.black);

        if (row % 2 != 0) {
            pn.setBackground(new Color(255, 255, 230));
        } else {
            pn.setBackground(new Color(230, 255, 255));
        }
        if (row == currentRow) {
            pn.setBackground(new Color(153, 255, 102));
        }

        super.getTableCellRendererComponent(table, value, isSelected,
                hasFocus, row, column);
        return pn;

    }
}
