echo off
title Sign In to AltspaceVR
curl -v -d "user[email]=goldjet45@gmail.com&user[password]=!myASVR556" https://account.altvr.com/users/sign_in.json -c cookie
