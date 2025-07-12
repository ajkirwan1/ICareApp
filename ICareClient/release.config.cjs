module.exports = {
  branches: [
    'master',
    { name: 'staging', prerelease: true },
    { name: 'develop', prerelease: 'dev' },
  ],
  plugins: [
    [
      '@semantic-release/commit-analyzer',
      {
        releaseRules: [
          { type: 'chore', release: 'patch' },  // <-- Added this line
        ],
      },
    ],
    '@semantic-release/release-notes-generator',
    '@semantic-release/changelog',
    [
      '@semantic-release/git',
      {
        assets: ['CHANGELOG.md', 'package.json'],
        message: 'chore(release): ${nextRelease.version} [skip ci]',
      },
    ],
    '@semantic-release/npm',
    '@semantic-release/github',
  ],
}
