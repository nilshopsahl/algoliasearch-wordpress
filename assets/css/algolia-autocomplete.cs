/*
Error: Base-level rules cannot contain the parent-selector-referencing character '&'.
        on line 127 of scss/algolia-autocomplete.scss

122:     &:nth-last-child(#{$nth}):first-child { &, & ~ * { @content; } }
123:   }
124: 
125: 
126: // Grid view
127: .algoliasearch-grid & {
128:   .aa-suggestions {
129:     &:before, &:after { content: " "; display: table; }
130:     &:after { clear: both; }
131:     *zoom: 1;
132:     border: 1px solid $border-color;

Backtrace:
scss/algolia-autocomplete.scss:127
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/selector/comma_sequence.rb:29:in `resolve_parent_refs'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/visitors/perform.rb:428:in `visit_rule'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/visitors/base.rb:36:in `visit'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/visitors/perform.rb:160:in `block in visit'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/stack.rb:79:in `block in with_base'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/stack.rb:115:in `with_frame'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/stack.rb:79:in `with_base'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/visitors/perform.rb:160:in `visit'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/visitors/base.rb:52:in `block in visit_children'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/visitors/base.rb:52:in `map'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/visitors/base.rb:52:in `visit_children'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/visitors/perform.rb:169:in `block in visit_children'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/visitors/perform.rb:181:in `with_environment'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/visitors/perform.rb:168:in `visit_children'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/visitors/base.rb:36:in `block in visit'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/visitors/perform.rb:188:in `visit_root'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/visitors/base.rb:36:in `visit'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/visitors/perform.rb:159:in `visit'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/visitors/perform.rb:8:in `visit'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/root_node.rb:36:in `css_tree'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/tree/root_node.rb:29:in `render_with_sourcemap'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/engine.rb:381:in `_render_with_sourcemap'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/engine.rb:298:in `render_with_sourcemap'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/exec/sass_scss.rb:391:in `run'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/exec/sass_scss.rb:63:in `process_result'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/exec/base.rb:52:in `parse'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/lib/sass/exec/base.rb:19:in `parse!'
/Library/Ruby/Gems/2.0.0/gems/sass-3.4.22/bin/sass:13:in `<top (required)>'
/usr/local/bin/sass:23:in `load'
/usr/local/bin/sass:23:in `<main>'
*/
body:before {
  white-space: pre;
  font-family: monospace;
  content: "Error: Base-level rules cannot contain the parent-selector-referencing character '&'.\A         on line 127 of scss/algolia-autocomplete.scss\A \A 122:     &:nth-last-child(#{$nth}):first-child { &, & ~ * { @content; } }\A 123:   }\A 124: \A 125: \A 126: // Grid view\A 127: .algoliasearch-grid & {\A 128:   .aa-suggestions {\A 129:     &:before, &:after { content: \" \"; display: table; }\A 130:     &:after { clear: both; }\A 131:     *zoom: 1;\A 132:     border: 1px solid $border-color;"; }
