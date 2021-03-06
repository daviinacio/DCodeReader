/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.daviapps.dcodeReader;

import com.daviapps.dcode.DCodeFile;

/**
 * @author Davi
 */
public class DCodeFileProps extends javax.swing.JDialog {
    
    //DCodeFile dFile;
    
    // Runnable
    Runnable save;
    
    public DCodeFileProps(java.awt.Frame parent, DCodeFile dFile) {
        super(parent, true);
        initComponents();
        
        //this.dFile = dFile;
        
        
        if(dFile.getStatusKey() == DCodeFile.ALRIGHT){
            Title_Edit.setText(dFile.getTitle());
            EncodeType_Edit.setText(dFile.getEncodeType());
            Content_TextArea.setText(dFile.getText());
        }
        
        save = new Runnable() {
            @Override
            public void run() {
                dFile.setTitle(Title_Edit.getText());
                dFile.setEncodeType(EncodeType_Edit.getText());
                dFile.setText(Content_TextArea.getText());
            }
        };
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        Main_Panel = new javax.swing.JPanel();
        Title_Panel = new javax.swing.JPanel();
        Title_Label = new javax.swing.JLabel();
        Title_Edit = new javax.swing.JTextField();
        EncodeType_Panel = new javax.swing.JPanel();
        EncodeType_Label = new javax.swing.JLabel();
        EncodeType_Edit = new javax.swing.JTextField();
        Content_Panel = new javax.swing.JPanel();
        Content_Label = new javax.swing.JLabel();
        Content_ScrollPane = new javax.swing.JScrollPane();
        Content_TextArea = new javax.swing.JTextArea();
        Buttons_Panel1 = new javax.swing.JPanel();
        Buttons_Save = new javax.swing.JButton();
        Buttons_Cancel = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("DCode File Props");
        setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        setLocationByPlatform(true);
        setResizable(false);

        Title_Label.setText("Título");

        javax.swing.GroupLayout Title_PanelLayout = new javax.swing.GroupLayout(Title_Panel);
        Title_Panel.setLayout(Title_PanelLayout);
        Title_PanelLayout.setHorizontalGroup(
            Title_PanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(Title_PanelLayout.createSequentialGroup()
                .addComponent(Title_Label)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addComponent(Title_Edit)
        );
        Title_PanelLayout.setVerticalGroup(
            Title_PanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(Title_PanelLayout.createSequentialGroup()
                .addComponent(Title_Label)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(Title_Edit, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
        );

        EncodeType_Label.setText("Encode type");

        javax.swing.GroupLayout EncodeType_PanelLayout = new javax.swing.GroupLayout(EncodeType_Panel);
        EncodeType_Panel.setLayout(EncodeType_PanelLayout);
        EncodeType_PanelLayout.setHorizontalGroup(
            EncodeType_PanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(EncodeType_PanelLayout.createSequentialGroup()
                .addComponent(EncodeType_Label)
                .addContainerGap(211, Short.MAX_VALUE))
            .addComponent(EncodeType_Edit)
        );
        EncodeType_PanelLayout.setVerticalGroup(
            EncodeType_PanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(EncodeType_PanelLayout.createSequentialGroup()
                .addComponent(EncodeType_Label)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(EncodeType_Edit, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
        );

        Content_Label.setText("Conteúdo");

        Content_TextArea.setColumns(20);
        Content_TextArea.setRows(5);
        Content_ScrollPane.setViewportView(Content_TextArea);

        javax.swing.GroupLayout Content_PanelLayout = new javax.swing.GroupLayout(Content_Panel);
        Content_Panel.setLayout(Content_PanelLayout);
        Content_PanelLayout.setHorizontalGroup(
            Content_PanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(Content_PanelLayout.createSequentialGroup()
                .addComponent(Content_Label)
                .addGap(0, 0, Short.MAX_VALUE))
            .addComponent(Content_ScrollPane)
        );
        Content_PanelLayout.setVerticalGroup(
            Content_PanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(Content_PanelLayout.createSequentialGroup()
                .addComponent(Content_Label)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(Content_ScrollPane))
        );

        javax.swing.GroupLayout Main_PanelLayout = new javax.swing.GroupLayout(Main_Panel);
        Main_Panel.setLayout(Main_PanelLayout);
        Main_PanelLayout.setHorizontalGroup(
            Main_PanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(Main_PanelLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(Main_PanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(Title_Panel, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(EncodeType_Panel, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(Content_Panel, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addContainerGap())
        );
        Main_PanelLayout.setVerticalGroup(
            Main_PanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(Main_PanelLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(Title_Panel, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(EncodeType_Panel, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(Content_Panel, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );

        Buttons_Save.setText("Salvar");
        Buttons_Save.setMaximumSize(new java.awt.Dimension(75, 23));
        Buttons_Save.setMinimumSize(new java.awt.Dimension(75, 23));
        Buttons_Save.setPreferredSize(new java.awt.Dimension(75, 23));
        Buttons_Save.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                Buttons_SaveActionPerformed(evt);
            }
        });

        Buttons_Cancel.setText("Cancelar");
        Buttons_Cancel.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                Buttons_CancelActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout Buttons_Panel1Layout = new javax.swing.GroupLayout(Buttons_Panel1);
        Buttons_Panel1.setLayout(Buttons_Panel1Layout);
        Buttons_Panel1Layout.setHorizontalGroup(
            Buttons_Panel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(Buttons_Panel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(Buttons_Save, javax.swing.GroupLayout.DEFAULT_SIZE, 102, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(Buttons_Cancel, javax.swing.GroupLayout.DEFAULT_SIZE, 103, Short.MAX_VALUE)
                .addContainerGap())
        );
        Buttons_Panel1Layout.setVerticalGroup(
            Buttons_Panel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(Buttons_Panel1Layout.createSequentialGroup()
                .addGroup(Buttons_Panel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(Buttons_Cancel, javax.swing.GroupLayout.PREFERRED_SIZE, 37, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(Buttons_Save, javax.swing.GroupLayout.PREFERRED_SIZE, 37, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(0, 0, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(Main_Panel, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(Buttons_Panel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(Main_Panel, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(Buttons_Panel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void Buttons_CancelActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_Buttons_CancelActionPerformed
        this.dispose();
    }//GEN-LAST:event_Buttons_CancelActionPerformed

    private void Buttons_SaveActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_Buttons_SaveActionPerformed
        this.save.run();
        this.dispose();
    }//GEN-LAST:event_Buttons_SaveActionPerformed

    /**
     * @param args the command line arguments
     */
    /*public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        /*try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(DCodeFileProps.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(DCodeFileProps.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(DCodeFileProps.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(DCodeFileProps.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the dialog */
        /*java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                DCodeFileProps dialog = new DCodeFileProps(new javax.swing.JFrame(), true);
                dialog.addWindowListener(new java.awt.event.WindowAdapter() {
                    @Override
                    public void windowClosing(java.awt.event.WindowEvent e) {
                        System.exit(0);
                    }
                });
                dialog.setVisible(true);
            }
        });
    }*/

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton Buttons_Cancel;
    private javax.swing.JPanel Buttons_Panel1;
    private javax.swing.JButton Buttons_Save;
    private javax.swing.JLabel Content_Label;
    private javax.swing.JPanel Content_Panel;
    private javax.swing.JScrollPane Content_ScrollPane;
    private javax.swing.JTextArea Content_TextArea;
    private javax.swing.JTextField EncodeType_Edit;
    private javax.swing.JLabel EncodeType_Label;
    private javax.swing.JPanel EncodeType_Panel;
    private javax.swing.JPanel Main_Panel;
    private javax.swing.JTextField Title_Edit;
    private javax.swing.JLabel Title_Label;
    private javax.swing.JPanel Title_Panel;
    // End of variables declaration//GEN-END:variables
}
