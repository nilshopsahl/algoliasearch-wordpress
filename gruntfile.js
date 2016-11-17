module.exports = function(grunt) {

  require('jit-grunt')(grunt);

  grunt.initConfig({

    // Compile SCSS
    sass: {
      dist: {
        options: {
          style: 'nested',
        },
        files: {
          'assets/css/algolia-autocomplete.css' : 'assets/scss/algolia-autocomplete.scss',
          'assets/css/algolia-instantsearch.css' : 'assets/scss/algolia-instantsearch.scss'
        }
      }
    },

    // Autoprefix
    postcss: {
      options: {
        map: false,
        processors: [
        require('autoprefixer')({
          browsers: ['> 20%', 'last 10 versions', 'Firefox > 20']
        })
        ],
        remove: false
      },
      dist: {
        src: 'assets/css/*.css'
      }
    },

    // Minify JS
    uglify: {
      my_target: {
        files: {
          'assets/js/autocomplete.js/autocomplete.min.js': ['assets/js/autocomplete.js/autocomplete.js']
        }
      }
    },

    // Watch for any changes
    watch: {
      // js: {
      //   files: ['assets/js/*.js'],
      // },
      css: {
        // Watch sass changes, merge mqs & run bs
        files: ['assets/scss/*.scss', 'assets/scss/**/*.scss', 'assets/js/autocomplete.js/autocomplete.js'],
        tasks: ['sass', 'postcss:dist', 'uglify' ]
      },
    }
  });

  // Standard grunt task – compile css and watch
  grunt.registerTask('default', [
    'sass',         // Run sass
    'postcss:dist', // Post Process with Auto-Prefix
    'uglify',       // Minify JS
    'watch'         // Keep watching for any changes
  ]);
};
