namespace pubg_dma_esp.PUBG
{
    internal static class Offsets
    {
        public readonly struct Util
        {
            public const bool OffsetDebug = false;
            public const bool CameraDebug = false;
            public const bool NamesDebug = false;
            public const bool PositionDebug = false;
        }

        public readonly struct DecryptFNameIndex // DecryptCIndex
        {
            public const uint Offset = 0x20; // UObject - Name (ObjectID)

            public const uint NameIndexXor1 = 0xF68FD56E;
            public const int NameIndexOne = 0x7; // ror (ShiftValue)
            public const int NameIndexTwo = 0x10; // shr/shl (?)
            public const uint NameIndexXor2 = 0x4FE6BC;
            public const bool NameIsROR = true;
        }

        public readonly struct Xenuine
        {
            public const uint Decrypt = 0xE874628;
        }

        public readonly struct GName
        {
            public const uint Base = 0x1053EFD8;
            public const bool OffsetBase = false;
            public const uint ElementsPerChunk = 0x3F74;
        }

        public readonly struct GWorld
        {
            public const uint Base = 0x102DCB68;
            // struct UWorld : UObject
            public const uint CurrentLevel = 0x150; // struct ULevel* CurrentLevel;
            public const uint GameInstance = 0x160; // padding[0x8] just below CurrentLevel
        }

        public readonly struct CurrentLevel
        {
            // struct ULevel : UObject
            public const uint Actors = 0x100; // inside of padding with a minimum size of 0x8
        }

        public readonly struct GameInstance
        {
            public const uint LocalPlayers = 0x38; // unsure
        }

        public readonly struct Player
        {
            public const uint Controller = 0x30; // unsure
        }

        public readonly struct PlayerController
        {
            // struct APlayerController : AController
            public const uint AcknowledgedPawn = 0x498; // struct APawn* (Self)
            public const uint CameraManager = 0x4C0; // struct APlayerCameraManager* PlayerCameraManager;
        }

        public readonly struct Actor
        {
            // struct AActor : UObject
            public const uint RootComponent = 0x1A8; // struct USceneComponent* RootComponent;
        }

        public readonly struct SceneComponent
        {
            public const uint ComponentToWorld = 0x320; // relative_location (unsure, should be +-20 of current value)
            public const uint Translation = 0x10; // Position !!!
        }

        public readonly struct Character
        {
            // struct ACharacter : APawn
            public const uint Mesh = 0x4B8; // struct USkeletalMeshComponent* Mesh;

            public static readonly uint[] HealthXorKeys = new uint[]
            {
                0xCEC7A59D,
                0x9B63B279,
                0xCA151DA5,
                0x7938488D,
                0xA911D0A,
                0x23DDAF5B,
                0x9458DC8,
                0xA521B421,
                0xBAF7A58,
                0xB0EF7987,
                0xE2756CB4,
                0x878ADB16,
                0xBD0ABCD5,
                0x79938D07,
                0x8D099E38,
                0xE0D52AA3,
            };

            public const uint HealthIf1 = 0x110; // HealthFlag
            public const uint HealthIf = 0xA28; // Health1
            public const uint HealthCheck = 0xA08; // Health4
            public const uint Healthxor = 0xA18; // Health6
            public const uint Healthcmp = 0xA1C; // Health3
            public const uint HealthBool = 0xA1D; // Health5
            public const uint HealthOffset = 0xA38; // Health2

            // struct ATslCharacterBase : ACharacter
            public const uint GroggyHealth = 0x2760; // float GroggyHealth;

            public const uint Name = 0x1D28;

            // struct ATslCharacter : AMutableCharacter
            public const uint Team = 0x1148; // right after "struct ATeam* Team;"
            public const uint SpectatedCount = 0x1110; // audience (obfuscated int32)
        }

        public readonly struct Mesh
        {
            // struct UPrimitiveComponent : USceneComponent
            // Right after BoundsScale
            public const uint LastRenderTimeOnScreen = 0x740; // 3rd float !!!
            public const uint LastSubmitTime = LastRenderTimeOnScreen - 0x8; // 1st float !!!

            // struct UStaticMeshComponent : UMeshComponent
            public const uint StaticMesh = 0xAC8; // struct UStaticMesh* StaticMesh; (BoneArray)
        }

        public readonly struct CameraManager
        {
            public const uint InfoBase = 0x1610; // Same as Location - Check struct from dump to ensure it's not changed !!!
        }
    }
}
