package com.daviapps.dcodereader.TabFragments;

import android.content.Context;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ListView;

import com.daviapps.dcodereader.R;

import java.io.File;

/**
 * Created by Davi on 17/02/2017.
 */
public class TabFragment extends Fragment{
    protected File file;
    protected Context context;
    protected String title;

    // Static variables
    public static int dFile = 0, dDB = 1, OtherFile = 2;

    // Methods
    public String getTitle(){
        return title;
    }

    // Static methods

    public static int getFileMode(String filedir) {
        if(true){ // DCodeFile.getStatusKey() == ALRIGHT
            if(true) // ...getEncodeType() == "DCode"
                return dFile;
            else
            if(true) // ...getEncodeType() == "DCodeDB"
                return dDB;
        }

        return OtherFile;
    }

    // Override methods
    @Override
    public String toString() {
        return file.getAbsolutePath();
    }
}
