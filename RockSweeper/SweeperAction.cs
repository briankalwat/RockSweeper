﻿using System.ComponentModel;

namespace RockSweeper
{
    public enum SweeperAction
    {
        #region General

        [Title( "Disable SSL for Sites and Pages" )]
        [Description( "Modifies all Sites and Pages and removes the requirement for an SSL connection." )]
        [Category( "General" )]
        [DefaultValue( true )]
        DisableSslForSitesAndPages,

        [Title( "Clear Exception Log" )]
        [Description( "Clears out the contents of the Rock Exception Log." )]
        [Category( "General" )]
        ClearExceptionLog,

        [Title( "Clear Person Tokens" )]
        [Description( "Clears out the contents of the PersonToken table." )]
        [Category( "General" )]
        ClearPersonTokens,

        #endregion

        #region System Settings

        [Title( "Sanitize Application Roots" )]
        [Description( "Modifies the PublicApplicationRoot and InternalApplicationRoot to safe values.")]
        [Category( "System Settings" )]
        [DefaultValue( true )]
        SanitizeApplicationRoots,

        [Title( "Disable Communication Transports" )]
        [Description( "Updates the Rock configuration to ensure that all communication transports are disabled." )]
        [Category( "System Settings" )]
        [DefaultValue( true )]
        DisableCommunicationTransports,

        [Title( "Reset Communication Transports" )]
        [Description( "Resets all transport configuration to system default values." )]
        [Category( "System Settings" )]
        ResetCommunicationTransports,

        [Title( "Configure For Localhost SMTP")]
        [Description( "Updates the communication settings to use a localhost SMTP server.")]
        [Category( "System Settings" )]
        [DefaultValue( true )]
        [AfterAction( DisableCommunicationTransports )]
        [AfterAction( ResetCommunicationTransports )]
        ConfigureForLocalhostSmtp,

        [Title( "Disable Financial Gateways" )]
        [Description( "Updates the Rock configuration to ensure that all financial gateways except the test gateway are disabled." )]
        [Category( "System Settings" )]
        [DefaultValue( true )]
        DisableFinancialGateways,

        [Title( "Reset Financial Gateways" )]
        [Description( "Resets all financial gateways except the test gateway to system default values." )]
        [Category( "System Settings" )]
        ResetFinancialGateways,

        [Title( "Disable External Authentication Services" )]
        [Description( "Updates the Rock configuration to ensure that authentication services other than database, AD and PIN are disabled." )]
        [Category( "System Settings" )]
        [DefaultValue( true )]
        DisableExternalAuthenticationServices,

        [Title( "Reset External Authentication Services" )]
        [Description( "Resets authentication services other than database, AD and PIN to system default values." )]
        [Category( "System Settings" )]
        ResetExternalAuthenticationServices,

        [Title( "Disable Authentication Services" )]
        [Description( "Updates the Rock configuration to ensure that authentication services other than database and PIN are disabled." )]
        [Category( "System Settings" )]
        [DefaultValue( true )]
        DisableAuthenticationServices,

        [Title( "Reset Authentication Services" )]
        [Description( "Resets authentication services other than database and PIN to system default values." )]
        [Category( "System Settings" )]
        ResetAuthenticationServices,

        [Title( "Disable Location Services" )]
        [Description( "Updates the Rock configuration to ensure that all location services are disabled." )]
        [Category( "System Settings" )]
        [DefaultValue( true )]
        DisableLocationServices,

        [Title( "Reset Location Services" )]
        [Description( "Resets all location services to system default values." )]
        [Category( "System Settings" )]
        ResetLocationServices,

        [Title( "Disable External Storage Providers" )]
        [Description( "Updates the Rock configuration to ensure that storage providers other than database and filesystem are disabled." )]
        [Category( "System Settings" )]
        [DefaultValue( true )]
        DisableExternalStorageProviders,

        [Title( "Reset External Storage Providers" )]
        [Description( "Resets storage providers other than database and filesystem to system default values." )]
        [Category( "System Settings" )]
        ResetExternalStorageProviders,

        [Title( "Disable Background Check Providers" )]
        [Description( "Updates the Rock configuration to ensure that all background check providers are disabled." )]
        [Category( "System Settings" )]
        [DefaultValue( true )]
        DisableBackgroundCheckProviders,

        [Title( "Reset Background Check Providers" )]
        [Description( "Resets all background check providers to system default values." )]
        [Category( "System Settings" )]
        ResetBackgroundCheckProviders,

        [Title( "Disable Signature Document Providers" )]
        [Description( "Updates the Rock configuration to ensure that all signed document providers are disabled." )]
        [Category( "System Settings" )]
        [DefaultValue( true )]
        DisableSignatureDocumentProviders,

        [Title( "Reset Signature Document Providers" )]
        [Description( "Resets all signed document providers to system default values." )]
        [Category( "System Settings" )]
        ResetSignatureDocumentProviders,

        [Title( "Disable Phone Systems" )]
        [Description( "Updates the Rock configuration to ensure that all phone systems are disabled." )]
        [Category( "System Settings" )]
        [DefaultValue( true )]
        DisablePhoneSystems,

        [Title( "Reset Phone Systems" )]
        [Description( "Resets all phone system settings to system default values." )]
        [Category( "System Settings" )]
        ResetPhoneSystems,

        [Title( "Reset Google API Keys" )]
        [Description( "Clears the Google API keys stored in global attributes." ) ]
        [Category( "System Settings" )]
        ResetGoogleApiKeys,

        #endregion

        #region Rock Jobs

        [Title( "Disable Rock Jobs" )]
        [Description( "Disables all Rock jobs except the Job Pulse." )]
        [Category( "Rock Jobs" )]
        [DefaultValue( true )]
        DisableRockJobs,

        #endregion

        #region Storage

        [Title( "Moves Binary Files Into Database" )]
        [Description( "Moves any binary file data stored externally into the database, this includes any filesystem storage.")]
        [Category( "Storage" )]
        MoveBinaryFilesIntoDatabase,

        [Title( "Replace Database Images With Sized Placeholders" )]
        [Description( "Replaces any database-stored PNG or JPG files with correctly sized placeholders." )]
        [Category( "Storage" )]
        [AfterAction( MoveBinaryFilesIntoDatabase )]
        ReplaceDatabaseImagesWithSizedPlaceholders,

        [Title( "Replace Database Images With Empty Placeholders" )]
        [Description( "Replaces any database-stored PNG or JPG files with 1x1 pixel placeholders." )]
        [Category( "Storage" )]
        [AfterAction( MoveBinaryFilesIntoDatabase )]
        ReplaceDatabaseImagesWithEmptyPlaceholders,

        [Title( "Replace Database Documents With Sized Placeholders" )]
        [Description( "Replaces any database-stored non-PNG and non-JPG files with placeholder text of the original file size." )]
        [Category( "Storage" )]
        [AfterAction( MoveBinaryFilesIntoDatabase )]
        ReplaceDatabaseDocumentsWithSizedPlaceholders,

        [Title( "Replace Database Documents With Empty Placeholders" )]
        [Description( "Replaces any databsae-stored non-PNG and non-JPG files with empty file content." )]
        [Category( "Storage" )]
        [AfterAction( MoveBinaryFilesIntoDatabase )]
        ReplaceDatabaseDocumentsWithEmptyPlaceholders,

        #endregion

        #region Data Scrubbing

        [Title( "Generate Random Email Addresses" )]
        [Description( "Replaces any e-mail addresses found in the system with generated values." )]
        [Category( "Data Scrubbing" )]
        GenerateRandomEmailAddresses,

        [Title( "Empty Analytics Source Tables" )]
        [Description( "Truncates the AnalyticsSource* tables so they contain no data." )]
        [Category( "Data Scrubbing" )]
        EmptyAnalyticsSourceTables,

        [Title( "Generate Random Logins" )]
        [Description( "Replaces any login names found in the system with generated values." )]
        [Category( "Data Scrubbing" )]
        GenerateRandomLogins,

        [Title( "Insert History Placeholders" )]
        [Description( "Modifies all History records to remove any identifying information." )]
        [Category( "Data Scrubbing" )]
        [AfterAction( GenerateRandomLogins )]
        InsertHistoryPlaceholders,

        [Title( "Sanitize Background Check Data" )]
        [Description( "Clears as much sensitive information from background checks as possible." )]
        [Category( "Data Scrubbing" )]
        [AfterAction( GenerateRandomNames )]
        SanitizeBackgroundCheckData,

        [Title( "Generate Random Phone Numbers " )]
        [Description( "Replaces any phone numbers found in the system with generated values." )]
        [Category( "Data Scrubbing" )]
        GenerateRandomPhoneNumbers,

        [Title( "Sanitize Benevolence Request Data" )]
        [Description( "Scrubs out any government IDs as well as request and result text." )]
        [Category( "Data Scrubbing" )]
        SanitizeBenevolenceRequestData,

        [Title( "Generate Random Names" )]
        [Description( "Replaces any person names with randomized names." )]
        [Category( "Data Scrubbing" )]
        GenerateRandomNames,

        [Title( "Sanitize Devices" )]
        [Description( "Replacing IPAddress with fake address information." )]
        [Category( "Data Scrubbing" )]
        SanitizeDevices,

        [Title( "Sanitize Content Channel Items" )]
        [Description( "Replaces content channel item content with ipsum text." )]
        [Category( "Data Scrubbing" )]
        SanitizeContentChannelItems,

        [Title( "Scrub Workflow Log" )]
        [Description( "Modifies the log text to only include the activity and action and not the specific action text." )]
        [Category( "Data Scrubbing" )]
        ScrubWorkflowLog,

        [Title( "Generate Organization and Campuses" )]
        [Description( "Scrubs the organization name and URL as well as campus names and URLs." )]
        [Category( "Data Scrubbing" )]
        GenerateOrganizationAndCampuses,
        
        #endregion
    }
}