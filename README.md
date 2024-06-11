# PixelPortalen Gamlestaden Web Application

This is my first-year student project developed as part of the coursework at IT-Högskolan Göteborg. The repository showcases the work done to create a web application for PixelPortalen Gamlestaden, leveraging Azure DevOps for project management and CI/CD, and hosting on the Azure Cloud.

## Overview

PixelPortalen Gamlestaden specializes in PC games and peripherals. The web application aims to expand their business by offering online sales, organizing LAN events, and managing user interactions and product ratings.

## Key Features

1. **Product Management**
   - Display products with filtering options by genre, name, price range, and age limit.
   - Comprehensive administrative features for managing products and orders.

2. **User Interaction**
   - Account creation, login, and purchase history.
   - Rating and commenting on products.

3. **Event Management**
   - Organizing LAN events and managing registrations and advertisements.

## Technical Stack

- **Backend**: .NET 8
- **Frontend**: Blazor
- **Database**: Azure SQL and CosmosDB
- **Hosting**: Microsoft Azure
- **CI/CD**: Azure DevOps with automated build and deployment pipelines

## Project Management with Azure DevOps

### Roles and Responsibilities

- **Cloud Developer**: Responsible for cloud services integration, deployment, scaling, security implementation, performance monitoring, troubleshooting, and maintenance.

### Initial Setup

- Set up Azure DevOps for project management and CI/CD pipelines.
- Configured repository and branch management using Gitflow Workflow.

## Cloud Services Integration

### Integration of Azure Services

- **Azure App Services**: Used for hosting the web application with different plans for development, testing, and production.
- **Azure SQL and CosmosDB**: Used for storing product, order, and customer information.
- **Azure CDN**: Configured for high availability and performance.

### Deployment Strategies and CI/CD Pipelines

- **Build Pipeline**: Automated build process with tasks for restoring packages, compiling code, running tests, and publishing artifacts.
- **Release Pipeline**: Three-stage deployment pipeline for test, development, and production environments, ensuring zero downtime with staging slots.

### Scaling Strategies

- **Scaling Up**: Adjusted service plans to include staging slots for better traffic management.
- **Scaling Out**: Implemented autoscaling based on CPU usage to handle varying loads efficiently.

## Security Implementation

- **HTTPS**: Ensured secure communication between the client and server.
- **Azure Active Directory**: Managed user authentication and authorization.
- **Data Encryption**: Implemented Transparent Data Encryption (TDE) for SQL database and automatic encryption for CosmosDB.
- **Network Security**: Utilized Azure Application Gateway and Web Application Firewall (WAF) to protect against vulnerabilities.

## Automation

### Azure Logic Apps Workflows

1. **PixelPortalen-Promotion-Services**
   - Automates the promotion of upcoming events to registered customers via email and SMS.
   
2. **Event Reminder**
   - Sends personalized reminders to customers who have booked an event, ensuring they do not miss it.

## Performance Monitoring, Troubleshooting, and Maintenance

- **Azure Application Insights**: Used for monitoring application performance and diagnosing issues.
- **Azure Monitor**: Set up alerts and diagnostic logs for real-time issue detection and troubleshooting.
- **Azure Automation**: Automated routine maintenance tasks and enforced compliance across the environment.

## Collaboration and Guidance

Engaged in continuous dialogue with team members to refine the backlog during sprint planning, ensuring technical tasks aligned with project goals and were effectively addressed.

## Conclusion

This project provided a comprehensive learning experience in developing, deploying, and managing a cloud-based web application. It highlighted the importance of collaboration, continuous integration, and robust security practices.

## License

This project is licensed under the MIT License - see the LICENSE.md file for details.
