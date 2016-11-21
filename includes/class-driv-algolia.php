<?php

class drivAlgolia {

    static $textdomain = 'driv_algolia';
    static $settingsKey = 'driv_algolia_settings';
    static $settings = false;

    public function __construct()
    {
        add_action( 'plugins_loaded',                               'drivAlgolia::load_textdomain' );
        add_filter( 'posts_orderby_request',                        'drivAlgolia::products_first_on_search', 10, 2);
    }

    static function set_settings_array()
    {
        self::$settings = (array) get_option( self::$settingsKey, array() ); 
    }

    static function get_settings_array()
    {
        if (self::$settings===false) {
            self::set_settings_array();
        }
        return self::$settings;
    }

    public static function driv_algolia_settings_js_var()
    {
        echo 'var drivAlgoliaSettings = ' . json_encode( self::get_settings_array() ) . ';';
    }

    static function load_textdomain()
    {
      $locale = apply_filters( 'plugin_locale', get_locale(), self::$textdomain );

      // Load textdomain
      $languages_dir =  plugin_basename( dirname( __FILE__ ) ) . '/assets/languages/';
      load_textdomain( self::$textdomain, $languages_dir . self::$textdomain . '-' . $locale . '.mo' );
      load_plugin_textdomain( self::$textdomain, false, dirname(plugin_basename( dirname( __FILE__ ) ) ) . '/assets/languages' );
    }

    static function products_first_on_search($order_by, $query)
    {
        global $wpdb;

        if (!empty($query->query_vars['s'])) {
            // compose order by clause to hoist products above other post types
            $products_first = "IF({$wpdb->posts}.post_type = 'product', 0, 1)";
            // insert clause at front of existing order by clause
            $order_by = empty($order_by) ? $products_first : "$products_first, $order_by";
        }

        return $order_by;
    }

    public static function get_current_settings($indices=null)
    {
        if (empty($indices)) {
            $indices = (array) get_option( 'algolia_synced_indices_ids', array() );
        }
        $settings = (array) get_option( self::$settingsKey, array() );
        if (count($settings)==0) {
            foreach ($indices as $index) {
                $settings[$index] = [];
                foreach (['view', 'empty_view'] as $setting) {
                    $settings[$index][$setting] = '';
                }
            }
        }
        return $settings;
    }

}

$drivAlgolia = new drivAlgolia;