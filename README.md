# Ticket-Management-System

A ticket tracking management system

This system currently under development, but the main idea can be illustrated as a helping desk ticketing system that helps various company to track issues/ send notifications/ manage the bugs etc.

Initial SRS can be simplified as:

User Role: developer, manager, QA, Customer Service, Client, System Administrator

Function:

QA started testing, if found bug, a ticket will be created.
The ticket includes bug description to show how to reproduce it and an area for leaving comments.
A notification will be sent to developer at the same time when a ticket is created.
When the bug resolved, developer can mark it to resolved. A notification will be sent to QA to double check.
Once the bug is resolved, QA has the right to mark it as closed with selection including: Issue Resolved, failed to resolve, Cancelled, Not an Issue.
Everyone except for client can see the tickets information.
Components:

System login page
Main page showing all tickets the default filtered by update datetime. It also can be filtered by ticket status and developer
Head section includes ticket operations: New Ticket, Edit Ticket, Delete Ticket, Assign Tickets (Manager only)
sidebar shows tickets categories: Pending, Closed, Trash box (storing deleted tickets).
