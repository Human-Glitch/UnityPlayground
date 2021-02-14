===========================
Install and Setup Jenkins
===========================
1. Install Jenkins locally to Windows
2. Install the following plugins to Jenkins:
    - Build Name and Description Setter
    - Github Integration Plugin
    - Unity3d plugin

3. Make sure Git is installed on the computer.
    - https://git-scm.com/download/win

4. Configure Unity 3d plugin to unity version file path
    - Go to Jenkins > Global Tool Configuration
    - Add name of the unity version
    - Add install directory ROOT folder like the following example:
        -> C:\Program Files\Unity\

===========================
Generate SSH Credentials 
Between Jenkins and Github
===========================
1. Generate public and private keys for a github credential user
    - Open the command line and enter the following:
        -> ssh-keygen

2. Go to Github and create a new SSH key under the account
    -> Enter the generated public RSA key

3. Create Github credentials user
    - Go to Jenkins > Credentials > Jenkins global user > Global credentials (unrestricted) > Add credentials
    - Add user info
    - Enter generated private RSA key

===========================
Create the Jenkins Job
===========================
1. Create Free Style project (Pipelines do not support Unity 3d plugin step)
    - Configure Github project with SSH url and 
    - Add github credential user and specify build branch
    - Check 'GitHub hook trigger for GITScm polling'
    - Check 'abort if build stuck'
    - Check 'Set Build Name' 
        -> ${JOB_NAME}#${BUILD_NUMBER}

2. Add build step with Unity 3d Editor
    - Use Unity version that matches game
    - Add the following build command:
        -> -nographics -batchmode -quit -executeMethod Assets.Editor.JenkinsBuild.BuildWindows64 ${JOB_NAME} "${JENKINS_HOME}"/jobs/${JOB_NAME}/builds/"${BUILD_NUMBER}"/output

3. Add post build step for notifications of Jenkins job status
    - Add email
    - Check 'Send email for every unstable build'

===========================
Configure Unity application
===========================
1. In unity, add the jenkins build class
    - In the unity, under Assets/Editor, add a JenkinsBuild.cs file
    - Include the following info to the class:
        -> https://gamefeelings.com/2020/02/18/jenkins-build-with-unity3d/

2. Commit and push changes

===========================
Set up Git webhooks:
===========================
1. Set up ngrok secure SSH tunnel for localhost connection to github
    - Download Ngrok
    - Sign in to Ngrok website
    - Follow instructions to set up ngrok credentials in downloaded application
        -> ngrok authtoken {token}
    - Set the localhost port to localhost:8080
        -> ngrok http 80

2. Copy SSH tunnel HTTPS URL

3. Go to Github for the desired repo
4. Add a webhook 
    - Go to the repo > settings > Webhooks > Add webhook
    - Add the ngrok HTTPS URL
    - Application type = json
    - Add a secret
    - Just push the event
    - Check active

5. Test webhook by commiting to the repo.

===========================
Deployment Notes:
===========================
1. Open Ngrok port and generate new url (url regrenerates on free version)
2. Update webhook url on Github project
3. Push new commit
