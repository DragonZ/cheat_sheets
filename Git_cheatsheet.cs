Source: https://www.atlassian.com/git/tutorials/setting-up-a-repository

Create git repository
	- git init
		- null ==> current working directory become git repository
		- <directory> ==> create empty git repository in <directory>
		- --bare flag ==> create shared/central repository

Copy git repository
	- git clone 
		- <repository> ==> copy <repository> to current working directory
		- <repository> <directory> ==> copy to <directory>

Configure git
	- git config <--global> user.name <name> ==> set username
	- git config <--global> user.email <email> ==> set email
	- git config <--global> alias.<alias-name> <git-command> ==> e.g. git config --global alias.ci commit
	- git config <--system> core.editor <editor> ==> set config editor system-wide
	- git config <--global> --edit ==> open (global) configuration file in editor
	- setting priority: local > user(global) > system
	- local: <repository>/.git/config
	- user(global): ~/.gitconfig
	- system: $(prefix)/etc/gitconfig

Staging git
	- git status ==> check staging area
	- .gitignore ==> ignore specific files from staging, *.pyc, *.exe ...
	- git add 
		- . ==> current working directory
		- <file> ==> stage changes in <file>
		- <directory> ==> stage all changes in <directory>
		- -p ==> begin an interactive staging session
			- y ==> stage the chunk
			- n ==> ignore the chunk
			- s ==> split into smaller chunks
			- e ==> manually edit the chunk
			- q ==> exit

Commit git
	- git log ==> display committed history
		- null ==> default format & all history
		- -n <limit> ==> number of commits to display
		- --oneline ==> one commit one line 
		- --stat ==> besides commit info & file modification details 
		- -p ==> patch representation
		- --author="<pattern>" ==> commits from certain author(name or regx)
		- --grep="<pattern>" ==> commits with message matching pattern (plain or regx)
		- <since>..<until> ==> commit between since and until, argument = revision reference
		- <file> ==> commits that include <file>
		- --graph --decorate --oneline ==> useful visual flags
		- revision~num ==> num before revision
	- git commit
		- null ==> commit staged snapshot, launch editor for message
		- -m "xxx" ==> commit with message "xxx"
		- -a ==> commit all changes in the working directory (waive add operation, but only tracked files, new file still need add)

		- commit message format 
			summary

			- detail1
			- detail2

** Undo changes **
Checkout git ==> make working directory match commit(for branching)/file
	- git checkout
		- master ==> restore back to master branch(current state), if no branch, nothing saved
		- <commit> ==> working directory to match <commit>, detached HEAD state
		- <commit> <file> ==> turn <file> in working directory into copy from <commit> and stage it
		- HEAD <file> ==> retore checkout-ed old <file> to current
Revert git
	- git revert
		- <commit> ==> generate new commit that undo all changes introduced in <commit>
		- use for shared public repository
Reset git
	- git reset
		- <file> ==> remove <file> from staging area, working directory unchanged
		- null ==> reset staging area to most recent commit, working directory unchanged
		- --hard ==> reset staging area and working directory to most recent commit
		- <commit> ==> move current branch to <commit>, reset staging area not working directory
		- --hard <commit> ==> reset staging area and working directory to <commit>
		- use for local repository
Clean git
	- git clean ==> remove untracked files
		- -n ==> show which files to remove without doing 
		- -f ==> remove untracked files unless specified by .gitignore
		- -f <path> ==> remove untracked files @ <path>
		- -df ==> remove untracked files and directories
		- -xf ==> remove untracked files as well as any files that git usually ignores

Manage connection
	- git remote
		- null ==> list remote connections
		- -v ==> list & include URL
		- add <name> <url> ==> add remote repo, <name> can be used as reference
		- rm <name> ==> remove connection
		- rename <old-name> <new-name> ==> rename one connection
		- origin remote is created by clone

Get remote changes
	- git fetch
		- <remote> ==> fetch all branches
		- <remote> <branch> ==> fetch specific branch
	
Check remote branch
	- git branch
		- r ==> list remote branches with repo prefix

Merge changes
	- git merge

Fetch&Merge remote changes
	- git pull
