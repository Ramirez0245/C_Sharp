import os

commit_name = input()

def commite(commit_name):
    print("Hello world")
    os.system("git add . | git commit  ")
    

commite(commit_name)