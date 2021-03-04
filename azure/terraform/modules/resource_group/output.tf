# end of infra

output "app_rg_name" {
  value       = azurerm_resource_group.rg_creation["app"].name
  description = "Resource Group name"
}

output "core_rg_name" {
  value       = azurerm_resource_group.rg_creation["core"].name
  description = "Resource Group name"
}

output "projcore_rg_name" {
  value       = azurerm_resource_group.rg_creation["projcore"].name
  description = "Resource Group name"
}

output "secrets_rg_name" {
  value       = azurerm_resource_group.rg_creation["secrets"].name
  description = "Resource Group name"
}

output "secrets_tmp_rg_name" {
  value       = azurerm_resource_group.rg_creation["secretstmp"].name
  description = "Resource Group name"
}

output "func_rg_name" {
  value       = azurerm_resource_group.rg_creation["funcapp"].name
  description = "Resource Group name"
}

# # infradev is managed in seperately 
# output "infra_rg_name" {
#   value       = "s118d01-infradev"
#   description = "infradev RG used for infrastrcuture items in development/PoC"
# }

output "rg_location" {
  value       = var.region
  description = "Location variable for Resource Group"
}

