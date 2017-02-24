package com.daviapps.dcodereader;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.main_menu, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle item selection
        switch (item.getItemId()) {
            case R.id.create_dcodeFile:
                Toast.makeText(MainActivity.this, "Novo DCode file", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.abrir_menu:
                Toast.makeText(MainActivity.this, "Abrir", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.salvar_menu:
                Toast.makeText(MainActivity.this, "Salvar", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.salvar_como_menu:
                Toast.makeText(MainActivity.this, "Salvar como", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.apagar_menu:
                Toast.makeText(MainActivity.this, "Apagar", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.detalhes_menu:
                Toast.makeText(MainActivity.this, "Detalhes", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.settings_menu:
                Toast.makeText(MainActivity.this, "Configurações", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.fechar_menu:
                Toast.makeText(MainActivity.this, "Fechar", Toast.LENGTH_SHORT).show();
                return true;
            default:
                return super.onOptionsItemSelected(item);
        }
    }
}
