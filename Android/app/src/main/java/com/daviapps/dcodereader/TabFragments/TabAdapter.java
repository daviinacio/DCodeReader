package com.daviapps.dcodereader.TabFragments;

import android.support.design.widget.TabLayout;
import android.support.v4.app.FragmentManager;
import android.support.v4.app.FragmentStatePagerAdapter;
import android.support.v4.view.ViewPager;
import android.view.View;

import com.daviapps.dcodereader.*;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Davi on 17/02/2017.
 */
public class TabAdapter extends FragmentStatePagerAdapter {
    private List<TabFragment> list;
    private MainActivity main_context;
    private ViewPager viewPager;
    private TabLayout tabLayout;

    public TabAdapter(FragmentManager fm, ViewPager vp, TabLayout tabLay, MainActivity main_context){
        super(fm);
        this.viewPager = vp; this.tabLayout = tabLay; this.main_context = main_context;
        this.tabLayout.setVisibility(View.GONE);
        list = new ArrayList<>();
        //this.initTabs();
    }

//    private void initTabs(){
//        for (int i = 0; i < list.size(); i++) {
//            tabLayout.addTab(tabLayout.newTab().setText(list.get(i)));
//        }
//        this.update();
//    }

    private void updatePager(){
        int j = viewPager.getCurrentItem();
        viewPager.setAdapter(this);
        viewPager.setOffscreenPageLimit(this.getCount());
        viewPager.setCurrentItem(j);
    }

    public void update(){
        //if(this.getCount() > 0)
        this.updatePager();
        if(this.getCount() <= 3)
            tabLayout.setTabGravity(TabLayout.GRAVITY_FILL);
        else
            tabLayout.setTabGravity(TabLayout.GRAVITY_CENTER);

        tabLayout.setVisibility(this.getCount() > 1 ? View.VISIBLE : View.GONE);

        if(this.getCount() > 1){
            main_context.setTitle(main_context.getString(R.string.app_name));
        } else
        if(this.getCount() == 1){
            main_context.setTitle(main_context.getString(R.string.app_name) + " - " + list.get(0).getTitle());
        }
    }

    public void updateTabName(int i){
        //tabLayout.getTabAt(i).setText(this.getItem(i).getName());
    }

    public void addTab(TabFragment tab){
        list.add(tab);
        tabLayout.addTab(tabLayout.newTab().setText(tab.getTitle()));
        update();
    }

    public void addTab(String fileDir){
        TabFragment tab = null;
        //int tabMode = TabFragment.getFileMode(fileDir);
        int tabMode = TabFragment.dFile;
        if(tabMode == TabFragment.dFile)
            tab = new DCodeFileFragment(fileDir);
        else
        if(tabMode == TabFragment.dDB)
            tab = new DCodeDBFragment();
        else
        if(tabMode == TabFragment.OtherFile)
            tab = new TextFileFragment();
        addTab(tab);
    }

    public void removeTab(int i){
        tabLayout.removeTabAt(i);
        list.remove(i);
        update();
    }

    @Override
    public TabFragment getItem(int position) {
        return list.get(position);
    }

    @Override
    public int getCount() {
        return list.size();
    }

    @Override
    public String getPageTitle(int position) {
        return list.get(position).getTitle();
    }
    // Methods

    // Override methods

    @Override
    public String toString(){
        String [] tabs = new String[this.getCount()];
        for(int i = 0; i < tabs.length; i++){
            tabs[i] = this.getItem(i).toString();
        }
        //return new DCode().enCode(tabs);
        return "[Diretory1:Diretory2:]";
    }
}
