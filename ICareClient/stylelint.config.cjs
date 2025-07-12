module.exports = {
    extends: [
      'stylelint-config-standard',
      'stylelint-config-css-modules',
    ],
    // If you want to lint CSS, SCSS, and CSS Modules (.module.css)
    overrides: [
      {
        files: ['**/*.css', '**/*.module.css'],
      },
    ],
    rules: {
      // Optional: your custom stylelint rules here
      'selector-class-pattern': [
        '^[a-z0-9\\-]+$', // kebab-case for class names (common in CSS Modules)
        {
          message:
            'Class names should be kebab-case (lowercase and hyphens only)',
        },
      ],
      // 'color-no-invalid-hex': true,
      // 'declaration-block-trailing-semicolon': 'always',
    },
  }
  