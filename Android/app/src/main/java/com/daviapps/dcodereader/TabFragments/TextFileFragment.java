package com.daviapps.dcodereader.TabFragments;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.daviapps.dcodereader.R;

import java.io.File;

/**
 * Created by Davi on 17/02/2017.
 */
public class TextFileFragment extends TabFragment {
    private String fileDir;
    public TextFileFragment(){
        title = "Novo Text";
    }

    @Override
    public View onCreateView(LayoutInflater inflater, final ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.otherfile_fragment, container, false);
        context = view.getContext();
        //this.file = new File(fileDir);
        //title = file.getName();

        //lista = (ListView) view.findViewById(R.id.tab_lay_list);


        return view;
    }
}
