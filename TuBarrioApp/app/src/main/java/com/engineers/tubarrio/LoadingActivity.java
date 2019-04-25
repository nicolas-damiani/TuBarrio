package com.engineers.tubarrio;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;

import com.engineers.tubarrio.activities.LoginActivity;

public class LoadingActivity extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_loading);

        Intent loginIntent = new Intent(LoadingActivity.this, LoginActivity.class);
        startActivity(loginIntent);
        finish();

    }
}
