package com.daviapps.dcodereader;

import android.os.Bundle;
import android.os.Environment;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.design.widget.TabLayout;
import android.support.v4.view.ViewPager;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Toast;

import com.daviapps.dcodereader.TabFragments.*;

public class MainActivity extends AppCompatActivity {
    private  TabAdapter tabs;
    private ViewPager viewPager;
    private TabLayout tabLayout;
    private int currentTab = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        viewPager = (ViewPager) findViewById(R.id.main_viewpager);
        tabLayout = (TabLayout) findViewById(R.id.main_tabLayout);

        tabs = new TabAdapter(getSupportFragmentManager(), viewPager, tabLayout, this);
        //tabs = new TabAdapter(getSupportFragmentManager(), dFile);
        //tabs = new TabAdapter(getSupportFragmentManager(), list);

        viewPager.addOnPageChangeListener(new TabLayout.TabLayoutOnPageChangeListener(tabLayout));
        tabLayout.setOnTabSelectedListener(new TabLayout.OnTabSelectedListener() {
            @Override
            public void onTabSelected(TabLayout.Tab tab) {
                if(tabs.getCount() >= 1)
                    viewPager.setCurrentItem(tab.getPosition());
                currentTab = tab.getPosition();
                //Toast.makeText(MainActivity.this, tab.getPosition(), Toast.LENGTH_SHORT).show();
            }

            @Override
            public void onTabUnselected(TabLayout.Tab tab) {

            }

            @Override
            public void onTabReselected(TabLayout.Tab tab) {

            }
        });

        //tabs.addTab("teste");
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        switch (item.getItemId()) {
            case R.id.menu_new_DCodeFile:
                tabs.addTab(new DCodeFileFragment());
                return true;
            case R.id.menu_new_DDBFile:
                tabs.addTab(new DCodeDBFragment());
                return true;
            case R.id.menu_new_TextFile:
                tabs.addTab(new TextFileFragment());
                return true;

            case R.id.menu_open:
                Toast.makeText(MainActivity.this, "Abrir", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.menu_save:
                Toast.makeText(MainActivity.this, "Salvar", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.menu_saveAs:
                Toast.makeText(MainActivity.this, "Salvar como", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.menu_delete:
                Toast.makeText(MainActivity.this, "Apagar", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.menu_details:
                Toast.makeText(MainActivity.this, "Detalhes", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.menu_settings:
                Toast.makeText(MainActivity.this, "Configurações", Toast.LENGTH_SHORT).show();
                return true;
            case R.id.menu_close:
                //Toast.makeText(MainActivity.this, "Fechar", Toast.LENGTH_SHORT).show();
                tabs.removeTab(currentTab);
                return true;
            default:
                return super.onOptionsItemSelected(item);
        }
    }
}
