import subprocess
import re

def list_wifi_profiles():
    """List all available WiFi profiles on the system."""
    try:
        result = subprocess.run(['netsh', 'wlan', 'show', 'profiles'], 
                                capture_output=True, text=True, shell=True)
        profiles = re.findall(r'All User Profile\s*:\s*(.+)', result.stdout)
        return profiles
    except Exception as e:
        print(f"Error listing WiFi profiles: {e}")
        return []

def create_mac_filter(target_mac):
    """
    Create a MAC address filter to restrict WiFi access to a specific device.
    Note: This requires administrative privileges.
    
    :param target_mac: MAC address of the target device to allow
    """
    try:
        # Create a netsh command to add MAC filter
        subprocess.run(['netsh', 'wlan', 'set', 'filter', 
                        f'mode=allow', 
                        f'mac={target_mac}'], 
                       check=True)
        print(f"WiFi access restricted to device with MAC: {target_mac}")
    except subprocess.CalledProcessError as e:
        print(f"Error setting MAC filter: {e}")

def block_all_devices_except(allowed_mac):
    """
    Block all devices except the specified MAC address.
    
    :param allowed_mac: MAC address of the device to allow
    """
    try:
        # First, clear existing filters
        subprocess.run(['netsh', 'wlan', 'set', 'filter', 'mode=allow'], check=True)
        
        # Block all other devices
        subprocess.run(['netsh', 'wlan', 'set', 'filter', 
                        f'mode=block', 
                        'mac=*'], 
                       check=True)
        
        # Allow specific device
        create_mac_filter(allowed_mac)
        
        print(f"WiFi access blocked for all devices except: {allowed_mac}")
    except subprocess.CalledProcessError as e:
        print(f"Error setting device filters: {e}")

def main():
    # Example usage
    print("Available WiFi Profiles:")
    profiles = list_wifi_profiles()
    for idx, profile in enumerate(profiles, 1):
        print(f"{idx}. {profile}")
    
    # Uncomment and replace with actual MAC address to restrict access
    # target_mac = "b4:8c:9d:8e:36:eb"  # Example MAC from the network info
    # block_all_devices_except(target_mac)

if __name__ == "__main__":
    main()