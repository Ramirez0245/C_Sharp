import subprocess
placeholder = input()
ACTIONS = [
    ["git","add", ".", "commit"],
    ["git", "commite", "-m", placeholder],
    ["git", "branch", "-M", "main"],
    ["git", "push", "-u", "origin", "orgin/main"]
    ]

for command in ACTIONS:
    print("Hello world")
    print(command)
    result = subprocess.run(command, shell=True, capture_output=True, text=True)
    print(result.stdout)

# commit_name = input()

# def commite(commit_name):
#     print("Hello world")

#     subprocess.run(["ls", "-l"])
#     # subprocess.run(["git add .", f'{commit_name}', 'git branch -M main', 'git push -u origin main'])
    

# commite(commit_name)