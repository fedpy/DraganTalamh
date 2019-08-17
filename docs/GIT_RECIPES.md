# Git Guidelines

## Introduction
This document is a mixture of Git recipes to support Dragan Talamh contributors while using Git. The recipes are written for Windows and Linux users. We will assume that you have Git installed on your machine. If not, installer for Windows can be found [here](https://git-scm.com/download/win) and for Linux [here](https://github.com/git/git) or [here](https://mirrors.edge.kernel.org/pub/software/scm/git/).

For those who want to learn more about ~~dark magic~~ Git, we recommend a publication written by Seth Robertson called ["Commit Often, Perfect Later, Publish Once: Git Best Practices"](https://sethrobertson.github.io/GitBestPractices/) where author disputes the intricacies of Git.

## Recommendations:
Commit often! Bare in mind that Commit !== Push. You should always Commit often to have multiple snapshots of your work in your local repository. Should anything bad happen, it is possible to restore files from just your local repository.

Please, please, please write meaningful Commit messages! Commit messages are vital to sustain sanity of everyone involved in the project. They are also a very useful tool in resolving conflicts, merging branches and generally proving how awesome you are!

Push only when you have fully implemented solution you have been tasked to do or you are going away from keyboard. Resist from Pushing unnecessarily as it will clutter the history of the project.

# Windows Instructions
- This is intentionally left ambigious.

# Command Line Instructions
## Initial Setup
- Grab a copy of current version of Dragan Talamh project:
```
git clone https://github.com/fedpy/DraganTalamh.git
```
- Get all commits and branches:
```
git fetch
```
- Switch to **development** branch:
```
git checkout -b development
```
- If you receive an error stating that the branch already exists, use this command instead:
```
git checkout development
```
- Update your local **development** branch:
```
git pull origin development
```

Well done! You are now ready to write an amazing code :star2:!

## Before you start working!
- Always check for the latest version of **development** branch
```
git pull origin development
```
- Get all commits and branches:
```
git fetch
```

Well done! Make sure to have plenty :coffee: and :cake: within reach before commencing any work!

## Sending your work to Git
- Stage files for the next commit
```
git add -A
```
- Check the working tree status
```
git status
```
- Commit your work!
```
git commit -m "Message for your commit goes here"
```
- Push your work to the **development** branch
```
git push -u origin development
```

Well done! Enjoy your coffee, tea, water or whatever other fluid! :tropical_drink:
